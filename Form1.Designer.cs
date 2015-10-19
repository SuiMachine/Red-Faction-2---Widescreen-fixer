namespace FovChanger
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LB_Running = new System.Windows.Forms.Label();
            this.T_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.C_KeyMode = new System.Windows.Forms.CheckBox();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_ResY = new System.Windows.Forms.TextBox();
            this.TB_ResX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DeveloperButton = new System.Windows.Forms.PictureBox();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.KeyPanel = new System.Windows.Forms.Panel();
            this.B_Key = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.L_fov = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeveloperButton)).BeginInit();
            this.KeyPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LB_Running
            // 
            this.LB_Running.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LB_Running.Dock = System.Windows.Forms.DockStyle.Top;
            this.LB_Running.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Running.ForeColor = System.Drawing.Color.Red;
            this.LB_Running.Location = new System.Drawing.Point(0, 0);
            this.LB_Running.Name = "LB_Running";
            this.LB_Running.Size = new System.Drawing.Size(302, 24);
            this.LB_Running.TabIndex = 1;
            this.LB_Running.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_Input
            // 
            this.T_Input.Location = new System.Drawing.Point(90, 47);
            this.T_Input.Name = "T_Input";
            this.T_Input.Size = new System.Drawing.Size(170, 20);
            this.T_Input.TabIndex = 37;
            this.T_Input.Text = "95";
            this.T_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.T_Input.TextChanged += new System.EventHandler(this.T_Input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Insert Fov";
            // 
            // C_KeyMode
            // 
            this.C_KeyMode.AutoSize = true;
            this.C_KeyMode.Location = new System.Drawing.Point(3, 9);
            this.C_KeyMode.Name = "C_KeyMode";
            this.C_KeyMode.Size = new System.Drawing.Size(59, 17);
            this.C_KeyMode.TabIndex = 40;
            this.C_KeyMode.Text = "Enable";
            this.C_KeyMode.UseVisualStyleBackColor = true;
            this.C_KeyMode.CheckedChanged += new System.EventHandler(this.C_KeyMode_CheckedChanged);
            // 
            // InputPanel
            // 
            this.InputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPanel.Controls.Add(this.label4);
            this.InputPanel.Controls.Add(this.TB_ResY);
            this.InputPanel.Controls.Add(this.TB_ResX);
            this.InputPanel.Controls.Add(this.label3);
            this.InputPanel.Controls.Add(this.DeveloperButton);
            this.InputPanel.Controls.Add(this.linkLabel);
            this.InputPanel.Controls.Add(this.KeyPanel);
            this.InputPanel.Controls.Add(this.label1);
            this.InputPanel.Controls.Add(this.T_Input);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InputPanel.Location = new System.Drawing.Point(0, 67);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(302, 168);
            this.InputPanel.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "x";
            // 
            // TB_ResY
            // 
            this.TB_ResY.Location = new System.Drawing.Point(185, 18);
            this.TB_ResY.Name = "TB_ResY";
            this.TB_ResY.Size = new System.Drawing.Size(75, 20);
            this.TB_ResY.TabIndex = 47;
            this.TB_ResY.Text = "720";
            this.TB_ResY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_ResY.TextChanged += new System.EventHandler(this.TB_ResY_TextChanged);
            // 
            // TB_ResX
            // 
            this.TB_ResX.Location = new System.Drawing.Point(90, 18);
            this.TB_ResX.Name = "TB_ResX";
            this.TB_ResX.Size = new System.Drawing.Size(75, 20);
            this.TB_ResX.TabIndex = 46;
            this.TB_ResX.Text = "1280";
            this.TB_ResX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_ResX.TextChanged += new System.EventHandler(this.TB_ResX_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Resolution:";
            // 
            // DeveloperButton
            // 
            this.DeveloperButton.Image = global::FovChanger.Properties.Resources.donatebutton;
            this.DeveloperButton.Location = new System.Drawing.Point(156, 133);
            this.DeveloperButton.Name = "DeveloperButton";
            this.DeveloperButton.Size = new System.Drawing.Size(74, 21);
            this.DeveloperButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DeveloperButton.TabIndex = 44;
            this.DeveloperButton.TabStop = false;
            this.DeveloperButton.Click += new System.EventHandler(this.DeveloperButton_Click);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(20, 137);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(84, 13);
            this.linkLabel.TabIndex = 43;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "PC Gaming Wiki";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // KeyPanel
            // 
            this.KeyPanel.Controls.Add(this.B_Key);
            this.KeyPanel.Controls.Add(this.C_KeyMode);
            this.KeyPanel.Location = new System.Drawing.Point(11, 79);
            this.KeyPanel.Name = "KeyPanel";
            this.KeyPanel.Size = new System.Drawing.Size(278, 37);
            this.KeyPanel.TabIndex = 41;
            // 
            // B_Key
            // 
            this.B_Key.Appearance = System.Windows.Forms.Appearance.Button;
            this.B_Key.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.B_Key.Location = new System.Drawing.Point(117, 4);
            this.B_Key.Name = "B_Key";
            this.B_Key.Size = new System.Drawing.Size(132, 24);
            this.B_Key.TabIndex = 41;
            this.B_Key.Text = "Set Key";
            this.B_Key.UseVisualStyleBackColor = true;
            this.B_Key.CheckedChanged += new System.EventHandler(this.B_Key_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.L_fov);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 43);
            this.panel1.TabIndex = 42;
            // 
            // L_fov
            // 
            this.L_fov.AutoSize = true;
            this.L_fov.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_fov.Location = new System.Drawing.Point(109, 15);
            this.L_fov.Name = "L_fov";
            this.L_fov.Size = new System.Drawing.Size(47, 13);
            this.L_fov.TabIndex = 1;
            this.L_fov.Text = "#####";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current Fov";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 235);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.LB_Running);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Fov Changer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeveloperButton)).EndInit();
            this.KeyPanel.ResumeLayout(false);
            this.KeyPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LB_Running;
        private System.Windows.Forms.TextBox T_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox C_KeyMode;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Panel KeyPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label L_fov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox B_Key;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.PictureBox DeveloperButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_ResY;
        private System.Windows.Forms.TextBox TB_ResX;
        private System.Windows.Forms.Label label3;
    }
}

