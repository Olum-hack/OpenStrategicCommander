﻿namespace OpenStrategicCommander.Forms
{
    partial class MainForm
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
            this.trkSwitch = new System.Windows.Forms.TrackBar();
            this.lblSwitchState = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.dlgLayoutSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgLayoutLoad = new System.Windows.Forms.OpenFileDialog();
            this.radMod1 = new System.Windows.Forms.RadioButton();
            this.radMod2 = new System.Windows.Forms.RadioButton();
            this.radMod3 = new System.Windows.Forms.RadioButton();
            this.bt_TestForm = new System.Windows.Forms.Button();
            this.axesPanel = new System.Windows.Forms.Panel();
            this.gb_SendOption = new System.Windows.Forms.GroupBox();
            this.rb_DownUp = new System.Windows.Forms.RadioButton();
            this.rb_SendKey = new System.Windows.Forms.RadioButton();
            this.rb_SendInput = new System.Windows.Forms.RadioButton();
            this.btnForward = new OpenStrategicCommander.Controls.CmdrButton();
            this.btnLeft = new OpenStrategicCommander.Controls.CmdrButton();
            this.btnBackward = new OpenStrategicCommander.Controls.CmdrButton();
            this.btnRight = new OpenStrategicCommander.Controls.CmdrButton();
            this.btn1 = new OpenStrategicCommander.Controls.CmdrButton();
            this.btn4 = new OpenStrategicCommander.Controls.CmdrButton();
            this.btn2 = new OpenStrategicCommander.Controls.CmdrButton();
            this.btn5 = new OpenStrategicCommander.Controls.CmdrButton();
            this.btn3 = new OpenStrategicCommander.Controls.CmdrButton();
            this.btnPlus = new OpenStrategicCommander.Controls.CmdrButton();
            this.btn6 = new OpenStrategicCommander.Controls.CmdrButton();
            this.btnMinus = new OpenStrategicCommander.Controls.CmdrButton();
            this.btnTurnLeft = new OpenStrategicCommander.Controls.CmdrButton();
            this.btnTurnRight = new OpenStrategicCommander.Controls.CmdrButton();
            ((System.ComponentModel.ISupportInitialize)(this.trkSwitch)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.axesPanel.SuspendLayout();
            this.gb_SendOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // trkSwitch
            // 
            this.trkSwitch.Location = new System.Drawing.Point(313, 97);
            this.trkSwitch.Maximum = 3;
            this.trkSwitch.Minimum = 1;
            this.trkSwitch.Name = "trkSwitch";
            this.trkSwitch.Size = new System.Drawing.Size(80, 45);
            this.trkSwitch.TabIndex = 2;
            this.trkSwitch.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkSwitch.Value = 1;
            // 
            // lblSwitchState
            // 
            this.lblSwitchState.Location = new System.Drawing.Point(313, 128);
            this.lblSwitchState.Name = "lblSwitchState";
            this.lblSwitchState.Size = new System.Drawing.Size(80, 17);
            this.lblSwitchState.TabIndex = 3;
            this.lblSwitchState.Text = "Switch 1";
            this.lblSwitchState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(410, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveLayoutToolStripMenuItem,
            this.loadLayoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveLayoutToolStripMenuItem
            // 
            this.saveLayoutToolStripMenuItem.Name = "saveLayoutToolStripMenuItem";
            this.saveLayoutToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveLayoutToolStripMenuItem.Text = "Save Layout";
            this.saveLayoutToolStripMenuItem.Click += new System.EventHandler(this.SaveLayoutToolStripMenuItem_Click);
            // 
            // loadLayoutToolStripMenuItem
            // 
            this.loadLayoutToolStripMenuItem.Name = "loadLayoutToolStripMenuItem";
            this.loadLayoutToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.loadLayoutToolStripMenuItem.Text = "Load Layout";
            this.loadLayoutToolStripMenuItem.Click += new System.EventHandler(this.LoadLayoutToolStripMenuItem_Click);
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.btn1);
            this.btnPanel.Controls.Add(this.btn4);
            this.btnPanel.Controls.Add(this.btn2);
            this.btnPanel.Controls.Add(this.btn5);
            this.btnPanel.Controls.Add(this.btn3);
            this.btnPanel.Controls.Add(this.btnPlus);
            this.btnPanel.Controls.Add(this.btn6);
            this.btnPanel.Controls.Add(this.btnMinus);
            this.btnPanel.Location = new System.Drawing.Point(12, 27);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(295, 120);
            this.btnPanel.TabIndex = 6;
            // 
            // dlgLayoutSave
            // 
            this.dlgLayoutSave.DefaultExt = "osc";
            this.dlgLayoutSave.Filter = "OSC Layouts|*.osc|All Files|*.*";
            this.dlgLayoutSave.Title = "Save Layout";
            // 
            // dlgLayoutLoad
            // 
            this.dlgLayoutLoad.DefaultExt = "osc";
            this.dlgLayoutLoad.Filter = "OSC Layouts|*.osc|All Files|*.*";
            this.dlgLayoutLoad.Title = "Load Layout";
            // 
            // radMod1
            // 
            this.radMod1.AutoCheck = false;
            this.radMod1.AutoSize = true;
            this.radMod1.Location = new System.Drawing.Point(316, 27);
            this.radMod1.Name = "radMod1";
            this.radMod1.Size = new System.Drawing.Size(71, 17);
            this.radMod1.TabIndex = 7;
            this.radMod1.TabStop = true;
            this.radMod1.Text = "Modifier 1";
            this.radMod1.UseVisualStyleBackColor = true;
            // 
            // radMod2
            // 
            this.radMod2.AutoCheck = false;
            this.radMod2.AutoSize = true;
            this.radMod2.Location = new System.Drawing.Point(316, 46);
            this.radMod2.Name = "radMod2";
            this.radMod2.Size = new System.Drawing.Size(71, 17);
            this.radMod2.TabIndex = 7;
            this.radMod2.TabStop = true;
            this.radMod2.Text = "Modifier 2";
            this.radMod2.UseVisualStyleBackColor = true;
            // 
            // radMod3
            // 
            this.radMod3.AutoCheck = false;
            this.radMod3.AutoSize = true;
            this.radMod3.Location = new System.Drawing.Point(316, 65);
            this.radMod3.Name = "radMod3";
            this.radMod3.Size = new System.Drawing.Size(71, 17);
            this.radMod3.TabIndex = 7;
            this.radMod3.TabStop = true;
            this.radMod3.Text = "Modifier 3";
            this.radMod3.UseVisualStyleBackColor = true;
            // 
            // bt_TestForm
            // 
            this.bt_TestForm.Location = new System.Drawing.Point(312, 250);
            this.bt_TestForm.Name = "bt_TestForm";
            this.bt_TestForm.Size = new System.Drawing.Size(75, 23);
            this.bt_TestForm.TabIndex = 8;
            this.bt_TestForm.Text = "Test Form";
            this.bt_TestForm.UseVisualStyleBackColor = true;
            this.bt_TestForm.Click += new System.EventHandler(this.Bt_TestForm_Click);
            // 
            // axesPanel
            // 
            this.axesPanel.Controls.Add(this.btnForward);
            this.axesPanel.Controls.Add(this.btnTurnRight);
            this.axesPanel.Controls.Add(this.btnTurnLeft);
            this.axesPanel.Controls.Add(this.btnLeft);
            this.axesPanel.Controls.Add(this.btnBackward);
            this.axesPanel.Controls.Add(this.btnRight);
            this.axesPanel.Location = new System.Drawing.Point(12, 153);
            this.axesPanel.Name = "axesPanel";
            this.axesPanel.Size = new System.Drawing.Size(295, 120);
            this.axesPanel.TabIndex = 6;
            // 
            // gb_SendOption
            // 
            this.gb_SendOption.Controls.Add(this.rb_SendInput);
            this.gb_SendOption.Controls.Add(this.rb_SendKey);
            this.gb_SendOption.Controls.Add(this.rb_DownUp);
            this.gb_SendOption.Location = new System.Drawing.Point(316, 153);
            this.gb_SendOption.Name = "gb_SendOption";
            this.gb_SendOption.Size = new System.Drawing.Size(87, 91);
            this.gb_SendOption.TabIndex = 9;
            this.gb_SendOption.TabStop = false;
            this.gb_SendOption.Text = "Key Send";
            // 
            // rb_DownUp
            // 
            this.rb_DownUp.AutoSize = true;
            this.rb_DownUp.Location = new System.Drawing.Point(6, 19);
            this.rb_DownUp.Name = "rb_DownUp";
            this.rb_DownUp.Size = new System.Drawing.Size(70, 17);
            this.rb_DownUp.TabIndex = 10;
            this.rb_DownUp.TabStop = true;
            this.rb_DownUp.Text = "Down-Up";
            this.rb_DownUp.UseVisualStyleBackColor = true;
            this.rb_DownUp.CheckedChanged += new System.EventHandler(this.KeySend_CheckedChanged);
            // 
            // rb_SendKey
            // 
            this.rb_SendKey.AutoSize = true;
            this.rb_SendKey.Location = new System.Drawing.Point(6, 42);
            this.rb_SendKey.Name = "rb_SendKey";
            this.rb_SendKey.Size = new System.Drawing.Size(68, 17);
            this.rb_SendKey.TabIndex = 10;
            this.rb_SendKey.TabStop = true;
            this.rb_SendKey.Text = "SendKey";
            this.rb_SendKey.UseVisualStyleBackColor = true;
            this.rb_SendKey.CheckedChanged += new System.EventHandler(this.KeySend_CheckedChanged);
            // 
            // rb_SendInput
            // 
            this.rb_SendInput.AutoSize = true;
            this.rb_SendInput.Location = new System.Drawing.Point(6, 65);
            this.rb_SendInput.Name = "rb_SendInput";
            this.rb_SendInput.Size = new System.Drawing.Size(74, 17);
            this.rb_SendInput.TabIndex = 10;
            this.rb_SendInput.TabStop = true;
            this.rb_SendInput.Text = "SendInput";
            this.rb_SendInput.UseVisualStyleBackColor = true;
            this.rb_SendInput.CheckedChanged += new System.EventHandler(this.KeySend_CheckedChanged);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(75, 3);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(69, 56);
            this.btnForward.TabIndex = 5;
            this.btnForward.Text = "/\\ ()";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.AxesBtn_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(3, 28);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(69, 56);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Tag = "4 (#)";
            this.btnLeft.Text = "< ()";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.AxesBtn_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(75, 61);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(69, 56);
            this.btnBackward.TabIndex = 0;
            this.btnBackward.Tag = "";
            this.btnBackward.Text = "\\/ ()";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.AxesBtn_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(150, 28);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(69, 56);
            this.btnRight.TabIndex = 0;
            this.btnRight.Tag = "6 (#)";
            this.btnRight.Text = "> ()";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.AxesBtn_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(0, -1);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(69, 56);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1 ()";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.CmdrBtn_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(0, 61);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(69, 56);
            this.btn4.TabIndex = 0;
            this.btn4.Tag = "4 (#)";
            this.btn4.Text = "4 ()";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.CmdrBtn_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(75, -1);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(69, 56);
            this.btn2.TabIndex = 0;
            this.btn2.Tag = "2 (#)";
            this.btn2.Text = "2 ()";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.CmdrBtn_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(75, 61);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(69, 56);
            this.btn5.TabIndex = 0;
            this.btn5.Tag = "5 (#)";
            this.btn5.Text = "5 ()";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.CmdrBtn_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(150, -1);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(69, 56);
            this.btn3.TabIndex = 0;
            this.btn3.Tag = "3 (#)";
            this.btn3.Text = "3 ()";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.CmdrBtn_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(225, -1);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(69, 56);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Tag = "+ (#)";
            this.btnPlus.Text = "+ ()";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.CmdrBtn_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(150, 61);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(69, 56);
            this.btn6.TabIndex = 0;
            this.btn6.Tag = "6 (#)";
            this.btn6.Text = "6 ()";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.CmdrBtn_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(225, 61);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(69, 56);
            this.btnMinus.TabIndex = 0;
            this.btnMinus.Tag = "- (#)";
            this.btnMinus.Text = "- ()";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.CmdrBtn_Click);
            // 
            // btnTurnLeft
            // 
            this.btnTurnLeft.Location = new System.Drawing.Point(225, 3);
            this.btnTurnLeft.Name = "btnTurnLeft";
            this.btnTurnLeft.Size = new System.Drawing.Size(37, 56);
            this.btnTurnLeft.TabIndex = 0;
            this.btnTurnLeft.Tag = "4 (#)";
            this.btnTurnLeft.Text = "< ()";
            this.btnTurnLeft.UseVisualStyleBackColor = true;
            this.btnTurnLeft.Click += new System.EventHandler(this.AxesBtn_Click);
            // 
            // btnTurnRight
            // 
            this.btnTurnRight.Location = new System.Drawing.Point(262, 3);
            this.btnTurnRight.Name = "btnTurnRight";
            this.btnTurnRight.Size = new System.Drawing.Size(33, 56);
            this.btnTurnRight.TabIndex = 0;
            this.btnTurnRight.Tag = "4 (#)";
            this.btnTurnRight.Text = "< ()";
            this.btnTurnRight.UseVisualStyleBackColor = true;
            this.btnTurnRight.Click += new System.EventHandler(this.AxesBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 278);
            this.Controls.Add(this.gb_SendOption);
            this.Controls.Add(this.bt_TestForm);
            this.Controls.Add(this.radMod1);
            this.Controls.Add(this.radMod3);
            this.Controls.Add(this.radMod2);
            this.Controls.Add(this.axesPanel);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.lblSwitchState);
            this.Controls.Add(this.trkSwitch);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.trkSwitch)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.btnPanel.ResumeLayout(false);
            this.axesPanel.ResumeLayout(false);
            this.gb_SendOption.ResumeLayout(false);
            this.gb_SendOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trkSwitch;
        private System.Windows.Forms.Label lblSwitchState;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Controls.CmdrButton btn1;
        private System.Windows.Forms.Panel btnPanel;
        private Controls.CmdrButton btn2;
        private Controls.CmdrButton btn3;
        private Controls.CmdrButton btn4;
        private Controls.CmdrButton btn5;
        private Controls.CmdrButton btn6;
        private Controls.CmdrButton btnPlus;
        private Controls.CmdrButton btnMinus;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadLayoutToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dlgLayoutSave;
        private System.Windows.Forms.OpenFileDialog dlgLayoutLoad;
        private System.Windows.Forms.RadioButton radMod1;
        private System.Windows.Forms.RadioButton radMod2;
        private System.Windows.Forms.RadioButton radMod3;
        private System.Windows.Forms.Button bt_TestForm;
        private System.Windows.Forms.Panel axesPanel;
        private Controls.CmdrButton btnForward;
        private Controls.CmdrButton btnLeft;
        private Controls.CmdrButton btnBackward;
        private Controls.CmdrButton btnRight;
        private System.Windows.Forms.GroupBox gb_SendOption;
        private System.Windows.Forms.RadioButton rb_SendKey;
        private System.Windows.Forms.RadioButton rb_DownUp;
        private System.Windows.Forms.RadioButton rb_SendInput;
        private Controls.CmdrButton btnTurnRight;
        private Controls.CmdrButton btnTurnLeft;
    }
}