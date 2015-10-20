using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;


namespace FovChanger
{
    public partial class Form1 : Form
    {
        // Base address value for pointers.
        int baseAddress = 0x0000000;

        // Other variables.
        System.Text.Encoding enc = System.Text.Encoding.UTF8;
        Process[] myProcess;
        string processName;
     
        float fov = 90;
        float fovPlus = 120;
        static float writeAspect = 1.0f;

        int ResX = 1280;
        int ResY = 720;
        float disiredAspect = 1.7777777f;
        
        float readAspect = 1.777777f;
        float prevReadAspect = 1.777777f;
        float readFov = 0;
        float readPrevFOV = 0;
        float displayedFOV = 0;


        int aspectAdress = 0x7AC188;
        int fovAddress = 0x00211C98;
        int[] offsets = new int[] { 0x64c };
        int fovInstruction = 0x00086F76;

        Keys Key = Keys.Tab;
      
        bool settingInputKey;
        bool overwriteInstruction = false;

        string labelUrl = "www.pcgamingwiki.com";
        string developerURL = "https://www.twitchalerts.com/donate/suicidemachine";


        /*------------------
        -- INITIALIZATION --
        ------------------*/
        public Form1()
        {
            InitializeComponent();
            processName = "rf2";
            RecalculateValues();
            FOVtoFOVWithAspect();
        }

        bool foundProcess = false;

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                myProcess = Process.GetProcessesByName(processName);
                if (myProcess.Length > 0)
                {
                    if (foundProcess == false)
                    {
                        System.Threading.Thread.Sleep(100);

                        IntPtr startOffset = myProcess[0].MainModule.BaseAddress;
                        IntPtr endOffset = IntPtr.Add(startOffset, myProcess[0].MainModule.ModuleMemorySize);
                        baseAddress = startOffset.ToInt32();
                    }

                    foundProcess = true;
                }
                else
                    foundProcess = false;

                if (foundProcess)
                {
                    // The game is running, ready for memory reading.
                    LB_Running.Text = "RED FACTION 2 IS RUNNING";
                    LB_Running.ForeColor = Color.Green;

                    readAspect = Trainer.ReadFloat(myProcess, baseAddress + aspectAdress);
                    if (readAspect != disiredAspect)
                        ChangeAspect();

                    readFov = Trainer.ReadPointerFloat(myProcess, baseAddress + fovAddress, offsets);
                    if (readFov != readPrevFOV)
                        readFOVToDisplayedFOV();

                    readPrevFOV = readFov;
                    prevReadAspect = readAspect;
                }
                else
                {
                    // The game process has not been found, reseting values.
                    LB_Running.Text = "RED FACTION 2 IS NOT RUNNING";
                    LB_Running.ForeColor = Color.Red;
                    ResetValues();
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void ChangeAspect()
        {
            if(foundProcess)
            {
                Trainer.WriteFloat(myProcess, baseAddress + aspectAdress, writeAspect);
            }
        }

        // Called when the game is not running or no mission is active.
        // Used to reset all the values.
        private void ResetValues()
        {
            L_fov.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer.Start();
        }

        public void InitHotkey()
        {
            if (!KeyGrabber.Hooked)
            {
                KeyGrabber.keyPressEvent += KeyGrabber_KeyPress;
                KeyGrabber.key.Clear();
                if (Key != Keys.None)
                    KeyGrabber.key.Add(Key);

                KeyGrabber.SetHook();
            }
            else
            {
                if (Key != Keys.None)
                {
                    KeyGrabber.key.Clear();
                    KeyGrabber.key.Add(Key);
                }
            }
        }

        private void RecalculateValues()
        {
            disiredAspect = ResX * 1.0f / ResY * 1.0f;
        }

        public void UnHook()
        {
            KeyGrabber.UnHook();
        }

        private void KeyGrabber_KeyPress(object sender, EventArgs e)
        {
            ChangeFov();
            if (overwriteInstruction)
                ChangeInstruction();

        }

        void ChangeFov()
        {
            if (foundProcess && readFov != fovPlus)
                Trainer.WritePointerFloat(myProcess, baseAddress + fovAddress, offsets, fovPlus);
        }

        void ChangeInstruction()
        {
            if (foundProcess)
                Trainer.WriteFloat(myProcess, baseAddress + fovInstruction, fovPlus);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (settingInputKey)
            {
                Key = keyData;
                B_Key.Text = Key.ToString();
                B_Key.Checked = false;
                InitHotkey();
                return true;
            }
                
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void B_Key_CheckedChanged(object sender, EventArgs e)
        {
            if (B_Key.Checked)
            {
                settingInputKey = true;
                B_Key.Text = "";
                C_KeyMode.Checked = true;
            }
            else
            {
                settingInputKey = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnHook();
        }


        private void C_KeyMode_CheckedChanged(object sender, EventArgs e)
        {
            if (C_KeyMode.Checked)
            {
                B_Key.Enabled = true;
                InitHotkey();
            }
            else
            {
                UnHook();
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(labelUrl);
        }

        private void DeveloperButton_Click(object sender, EventArgs e)
        {
            Process.Start(developerURL);
        }

        private void T_Input_TextChanged(object sender, EventArgs e)
        {
            float temp;
            if(float.TryParse(T_Input.Text, out temp))
            {
                fov = temp;
                RecalculateValues();
                FOVtoFOVWithAspect();
            }
        }

        private void TB_ResX_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if(int.TryParse(TB_ResX.Text, out temp))
            {
                ResX = temp;
                RecalculateValues();
                FOVtoFOVWithAspect();
            }
        }

        private void TB_ResY_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (int.TryParse(TB_ResY.Text, out temp))
            {
                ResY = temp;
                RecalculateValues();
                FOVtoFOVWithAspect();
            }
        }

        ///////////////////////////////
        ///CALCULATOR FUNCTIONS////////
        ///////////////////////////////

        private void FOVtoFOVWithAspect()
        {
            fovPlus = (fov * disiredAspect) / 1.333333333f;
        }

        private void readFOVToDisplayedFOV()
        {
            displayedFOV = readFov * 1.33333333f / disiredAspect;
            L_fov.Text = displayedFOV.ToString();
        }

        private void C_OverwriteInstructions_CheckedChanged(object sender, EventArgs e)
        {
            if (C_OverwriteInstructions.Checked)
            {
                MessageBox.Show("This option can crash a game, but it should prevent from FOV reseting to default value after cutscenes. If you're having problems with the game's stability, disable this option.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                overwriteInstruction = true;
            }
            else
                overwriteInstruction = false;
        }
    }
}
