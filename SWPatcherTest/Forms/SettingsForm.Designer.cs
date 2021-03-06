﻿namespace SWPatcherTest.Forms
{
    partial class SettingsForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageGame = new System.Windows.Forms.TabPage();
            this.groupBoxPatchExe = new System.Windows.Forms.GroupBox();
            this.checkBoxPatchExe = new System.Windows.Forms.CheckBox();
            this.groupBoxPatcherDirectory = new System.Windows.Forms.GroupBox();
            this.buttonPatcherChangeDirectory = new System.Windows.Forms.Button();
            this.textBoxPatcherDirectory = new System.Windows.Forms.TextBox();
            this.groupBoxGameDirectory = new System.Windows.Forms.GroupBox();
            this.buttonGameChangeDirectory = new System.Windows.Forms.Button();
            this.textBoxGameDirectory = new System.Windows.Forms.TextBox();
            this.tabPageCredentials = new System.Windows.Forms.TabPage();
            this.groupBoxGameUserId = new System.Windows.Forms.GroupBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.groupBoxGameUserPassword = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.groupBoxGameWantLogin = new System.Windows.Forms.GroupBox();
            this.checkBoxWantToLogin = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageGame.SuspendLayout();
            this.groupBoxPatchExe.SuspendLayout();
            this.groupBoxPatcherDirectory.SuspendLayout();
            this.groupBoxGameDirectory.SuspendLayout();
            this.tabPageCredentials.SuspendLayout();
            this.groupBoxGameUserId.SuspendLayout();
            this.groupBoxGameUserPassword.SuspendLayout();
            this.groupBoxGameWantLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel.Controls.Add(this.buttonApply, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonCancel, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonOk, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.tabControl, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(320, 252);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // buttonApply
            // 
            this.buttonApply.Enabled = false;
            this.buttonApply.Location = new System.Drawing.Point(242, 224);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 3;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(161, 224);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(80, 224);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // tabControl
            // 
            this.tableLayoutPanel.SetColumnSpan(this.tabControl, 4);
            this.tabControl.Controls.Add(this.tabPageGame);
            this.tabControl.Controls.Add(this.tabPageCredentials);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(314, 215);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageGame
            // 
            this.tabPageGame.Controls.Add(this.groupBoxPatchExe);
            this.tabPageGame.Controls.Add(this.groupBoxPatcherDirectory);
            this.tabPageGame.Controls.Add(this.groupBoxGameDirectory);
            this.tabPageGame.Location = new System.Drawing.Point(4, 22);
            this.tabPageGame.Name = "tabPageGame";
            this.tabPageGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGame.Size = new System.Drawing.Size(306, 189);
            this.tabPageGame.TabIndex = 0;
            this.tabPageGame.Text = "Soulworker";
            this.tabPageGame.UseVisualStyleBackColor = true;
            // 
            // groupBoxPatchExe
            // 
            this.groupBoxPatchExe.AutoSize = true;
            this.groupBoxPatchExe.Controls.Add(this.checkBoxPatchExe);
            this.groupBoxPatchExe.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxPatchExe.Location = new System.Drawing.Point(3, 125);
            this.groupBoxPatchExe.Name = "groupBoxPatchExe";
            this.groupBoxPatchExe.Size = new System.Drawing.Size(300, 61);
            this.groupBoxPatchExe.TabIndex = 2;
            this.groupBoxPatchExe.TabStop = false;
            this.groupBoxPatchExe.Text = "Patching .exe to support other unicode languages";
            // 
            // checkBoxPatchExe
            // 
            this.checkBoxPatchExe.AutoSize = true;
            this.checkBoxPatchExe.Location = new System.Drawing.Point(6, 25);
            this.checkBoxPatchExe.Name = "checkBoxPatchExe";
            this.checkBoxPatchExe.Size = new System.Drawing.Size(253, 17);
            this.checkBoxPatchExe.TabIndex = 0;
            this.checkBoxPatchExe.Text = "Yes, I am aware of the risks and want to patch it";
            this.checkBoxPatchExe.UseVisualStyleBackColor = true;
            this.checkBoxPatchExe.CheckedChanged += new System.EventHandler(this.checkBoxPatchExe_CheckedChanged);
            // 
            // groupBoxPatcherDirectory
            // 
            this.groupBoxPatcherDirectory.AutoSize = true;
            this.groupBoxPatcherDirectory.Controls.Add(this.buttonPatcherChangeDirectory);
            this.groupBoxPatcherDirectory.Controls.Add(this.textBoxPatcherDirectory);
            this.groupBoxPatcherDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxPatcherDirectory.Location = new System.Drawing.Point(3, 64);
            this.groupBoxPatcherDirectory.Name = "groupBoxPatcherDirectory";
            this.groupBoxPatcherDirectory.Size = new System.Drawing.Size(300, 61);
            this.groupBoxPatcherDirectory.TabIndex = 1;
            this.groupBoxPatcherDirectory.TabStop = false;
            this.groupBoxPatcherDirectory.Text = "Patcher location";
            // 
            // buttonPatcherChangeDirectory
            // 
            this.buttonPatcherChangeDirectory.Location = new System.Drawing.Point(219, 19);
            this.buttonPatcherChangeDirectory.Name = "buttonPatcherChangeDirectory";
            this.buttonPatcherChangeDirectory.Size = new System.Drawing.Size(75, 23);
            this.buttonPatcherChangeDirectory.TabIndex = 1;
            this.buttonPatcherChangeDirectory.Text = "Change";
            this.buttonPatcherChangeDirectory.UseVisualStyleBackColor = true;
            this.buttonPatcherChangeDirectory.Click += new System.EventHandler(this.buttonPatcherChangeDirectory_Click);
            // 
            // textBoxPatcherDirectory
            // 
            this.textBoxPatcherDirectory.Location = new System.Drawing.Point(6, 21);
            this.textBoxPatcherDirectory.Name = "textBoxPatcherDirectory";
            this.textBoxPatcherDirectory.ReadOnly = true;
            this.textBoxPatcherDirectory.Size = new System.Drawing.Size(207, 20);
            this.textBoxPatcherDirectory.TabIndex = 0;
            // 
            // groupBoxGameDirectory
            // 
            this.groupBoxGameDirectory.AutoSize = true;
            this.groupBoxGameDirectory.Controls.Add(this.buttonGameChangeDirectory);
            this.groupBoxGameDirectory.Controls.Add(this.textBoxGameDirectory);
            this.groupBoxGameDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxGameDirectory.Location = new System.Drawing.Point(3, 3);
            this.groupBoxGameDirectory.Name = "groupBoxGameDirectory";
            this.groupBoxGameDirectory.Size = new System.Drawing.Size(300, 61);
            this.groupBoxGameDirectory.TabIndex = 0;
            this.groupBoxGameDirectory.TabStop = false;
            this.groupBoxGameDirectory.Text = "Game location";
            // 
            // buttonGameChangeDirectory
            // 
            this.buttonGameChangeDirectory.Location = new System.Drawing.Point(219, 19);
            this.buttonGameChangeDirectory.Name = "buttonGameChangeDirectory";
            this.buttonGameChangeDirectory.Size = new System.Drawing.Size(75, 23);
            this.buttonGameChangeDirectory.TabIndex = 1;
            this.buttonGameChangeDirectory.Text = "Change";
            this.buttonGameChangeDirectory.UseVisualStyleBackColor = true;
            this.buttonGameChangeDirectory.Click += new System.EventHandler(this.buttonChangeDirectory_Click);
            // 
            // textBoxGameDirectory
            // 
            this.textBoxGameDirectory.Location = new System.Drawing.Point(6, 21);
            this.textBoxGameDirectory.Name = "textBoxGameDirectory";
            this.textBoxGameDirectory.ReadOnly = true;
            this.textBoxGameDirectory.Size = new System.Drawing.Size(207, 20);
            this.textBoxGameDirectory.TabIndex = 0;
            // 
            // tabPageCredentials
            // 
            this.tabPageCredentials.Controls.Add(this.groupBoxGameWantLogin);
            this.tabPageCredentials.Controls.Add(this.groupBoxGameUserPassword);
            this.tabPageCredentials.Controls.Add(this.groupBoxGameUserId);
            this.tabPageCredentials.Location = new System.Drawing.Point(4, 22);
            this.tabPageCredentials.Name = "tabPageCredentials";
            this.tabPageCredentials.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCredentials.Size = new System.Drawing.Size(306, 189);
            this.tabPageCredentials.TabIndex = 1;
            this.tabPageCredentials.Text = "Credentials";
            this.tabPageCredentials.UseVisualStyleBackColor = true;
            // 
            // groupBoxGameUserId
            // 
            this.groupBoxGameUserId.AutoSize = true;
            this.groupBoxGameUserId.Controls.Add(this.textBoxId);
            this.groupBoxGameUserId.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxGameUserId.Location = new System.Drawing.Point(3, 3);
            this.groupBoxGameUserId.Name = "groupBoxGameUserId";
            this.groupBoxGameUserId.Size = new System.Drawing.Size(300, 60);
            this.groupBoxGameUserId.TabIndex = 0;
            this.groupBoxGameUserId.TabStop = false;
            this.groupBoxGameUserId.Text = "Soulworker ID";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(6, 21);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(180, 20);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // groupBoxGameUserPassword
            // 
            this.groupBoxGameUserPassword.AutoSize = true;
            this.groupBoxGameUserPassword.Controls.Add(this.textBoxPassword);
            this.groupBoxGameUserPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxGameUserPassword.Location = new System.Drawing.Point(3, 63);
            this.groupBoxGameUserPassword.Name = "groupBoxGameUserPassword";
            this.groupBoxGameUserPassword.Size = new System.Drawing.Size(300, 60);
            this.groupBoxGameUserPassword.TabIndex = 1;
            this.groupBoxGameUserPassword.TabStop = false;
            this.groupBoxGameUserPassword.Text = "Soulworker Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(6, 21);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(180, 20);
            this.textBoxPassword.TabIndex = 0;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // groupBoxGameWantLogin
            // 
            this.groupBoxGameWantLogin.AutoSize = true;
            this.groupBoxGameWantLogin.Controls.Add(this.checkBoxWantToLogin);
            this.groupBoxGameWantLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxGameWantLogin.Location = new System.Drawing.Point(3, 123);
            this.groupBoxGameWantLogin.Name = "groupBoxGameWantLogin";
            this.groupBoxGameWantLogin.Size = new System.Drawing.Size(300, 61);
            this.groupBoxGameWantLogin.TabIndex = 2;
            this.groupBoxGameWantLogin.TabStop = false;
            this.groupBoxGameWantLogin.Text = "Tired to login from the website?";
            // 
            // checkBoxWantToLogin
            // 
            this.checkBoxWantToLogin.AutoSize = true;
            this.checkBoxWantToLogin.Location = new System.Drawing.Point(6, 25);
            this.checkBoxWantToLogin.Name = "checkBoxWantToLogin";
            this.checkBoxWantToLogin.Size = new System.Drawing.Size(138, 17);
            this.checkBoxWantToLogin.TabIndex = 0;
            this.checkBoxWantToLogin.Text = "Login using the Patcher";
            this.checkBoxWantToLogin.UseVisualStyleBackColor = true;
            this.checkBoxWantToLogin.CheckedChanged += new System.EventHandler(this.checkBoxWantToLogin_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 252);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageGame.ResumeLayout(false);
            this.tabPageGame.PerformLayout();
            this.groupBoxPatchExe.ResumeLayout(false);
            this.groupBoxPatchExe.PerformLayout();
            this.groupBoxPatcherDirectory.ResumeLayout(false);
            this.groupBoxPatcherDirectory.PerformLayout();
            this.groupBoxGameDirectory.ResumeLayout(false);
            this.groupBoxGameDirectory.PerformLayout();
            this.tabPageCredentials.ResumeLayout(false);
            this.tabPageCredentials.PerformLayout();
            this.groupBoxGameUserId.ResumeLayout(false);
            this.groupBoxGameUserId.PerformLayout();
            this.groupBoxGameUserPassword.ResumeLayout(false);
            this.groupBoxGameUserPassword.PerformLayout();
            this.groupBoxGameWantLogin.ResumeLayout(false);
            this.groupBoxGameWantLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageGame;
        private System.Windows.Forms.GroupBox groupBoxGameDirectory;
        private System.Windows.Forms.Button buttonGameChangeDirectory;
        private System.Windows.Forms.TextBox textBoxGameDirectory;
        private System.Windows.Forms.GroupBox groupBoxPatcherDirectory;
        private System.Windows.Forms.Button buttonPatcherChangeDirectory;
        private System.Windows.Forms.TextBox textBoxPatcherDirectory;
        private System.Windows.Forms.GroupBox groupBoxPatchExe;
        private System.Windows.Forms.CheckBox checkBoxPatchExe;
        private System.Windows.Forms.TabPage tabPageCredentials;
        private System.Windows.Forms.GroupBox groupBoxGameUserPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.GroupBox groupBoxGameUserId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.GroupBox groupBoxGameWantLogin;
        private System.Windows.Forms.CheckBox checkBoxWantToLogin;
    }
}