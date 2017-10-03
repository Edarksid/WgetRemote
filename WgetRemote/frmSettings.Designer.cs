namespace WgetRemote
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.cmdOk = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtSshHost = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtSshPort = new System.Windows.Forms.MaskedTextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtSshLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtSshPass = new System.Windows.Forms.TextBox();
            this.lblKeyFile = new System.Windows.Forms.Label();
            this.txtSshKey = new System.Windows.Forms.TextBox();
            this.cmdBrowseKeyFile = new System.Windows.Forms.Button();
            this.chkAutoUpdate = new System.Windows.Forms.CheckBox();
            this.txtAutoUpdateInt = new System.Windows.Forms.MaskedTextBox();
            this.chkClipboardMon = new System.Windows.Forms.CheckBox();
            this.grbConnectionSettings = new System.Windows.Forms.GroupBox();
            this.grbCommonSettings = new System.Windows.Forms.GroupBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.grbServerSettings = new System.Windows.Forms.GroupBox();
            this.txtFinishedMark = new System.Windows.Forms.TextBox();
            this.lblFinishedMark = new System.Windows.Forms.Label();
            this.txtRmCmd = new System.Windows.Forms.TextBox();
            this.lblRmCmd = new System.Windows.Forms.Label();
            this.txtKillCmd = new System.Windows.Forms.TextBox();
            this.lblKillCmd = new System.Windows.Forms.Label();
            this.txtMkDirCmd = new System.Windows.Forms.TextBox();
            this.lblMkDirCmd = new System.Windows.Forms.Label();
            this.txtReadLogCmd = new System.Windows.Forms.TextBox();
            this.lblReadLogCmd = new System.Windows.Forms.Label();
            this.txtPsCmd = new System.Windows.Forms.TextBox();
            this.lblPsCmd = new System.Windows.Forms.Label();
            this.txtWgetCmd = new System.Windows.Forms.TextBox();
            this.lblWgetCmd = new System.Windows.Forms.Label();
            this.grbServerPath = new System.Windows.Forms.GroupBox();
            this.txtLstDir = new System.Windows.Forms.TextBox();
            this.lblLstDir = new System.Windows.Forms.Label();
            this.txtLogsDir = new System.Windows.Forms.TextBox();
            this.lblLogsDir = new System.Windows.Forms.Label();
            this.txtDownloadsDir = new System.Windows.Forms.TextBox();
            this.lblDownloadsDir = new System.Windows.Forms.Label();
            this.cmdTestConnection = new System.Windows.Forms.Button();
            this.grbConnectionSettings.SuspendLayout();
            this.grbCommonSettings.SuspendLayout();
            this.grbServerSettings.SuspendLayout();
            this.grbServerPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(475, 330);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(109, 33);
            this.cmdOk.TabIndex = 0;
            this.cmdOk.Text = "Ok";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(823, 329);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(109, 33);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(3, 16);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(41, 13);
            this.lblServer.TabIndex = 2;
            this.lblServer.Text = "Server:";
            // 
            // txtSshHost
            // 
            this.txtSshHost.Location = new System.Drawing.Point(6, 32);
            this.txtSshHost.Name = "txtSshHost";
            this.txtSshHost.Size = new System.Drawing.Size(107, 20);
            this.txtSshHost.TabIndex = 3;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(128, 16);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 20;
            this.lblPort.Text = "Port:";
            // 
            // txtSshPort
            // 
            this.txtSshPort.Location = new System.Drawing.Point(131, 32);
            this.txtSshPort.Mask = "00000";
            this.txtSshPort.Name = "txtSshPort";
            this.txtSshPort.Size = new System.Drawing.Size(47, 20);
            this.txtSshPort.TabIndex = 21;
            this.txtSshPort.ValidatingType = typeof(int);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(193, 16);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 22;
            this.lblLogin.Text = "Login:";
            // 
            // txtSshLogin
            // 
            this.txtSshLogin.Location = new System.Drawing.Point(196, 32);
            this.txtSshLogin.Name = "txtSshLogin";
            this.txtSshLogin.Size = new System.Drawing.Size(130, 20);
            this.txtSshLogin.TabIndex = 23;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(339, 16);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 24;
            this.lblPassword.Text = "Password:";
            // 
            // txtSshPass
            // 
            this.txtSshPass.Location = new System.Drawing.Point(342, 32);
            this.txtSshPass.Name = "txtSshPass";
            this.txtSshPass.PasswordChar = '*';
            this.txtSshPass.Size = new System.Drawing.Size(109, 20);
            this.txtSshPass.TabIndex = 25;
            // 
            // lblKeyFile
            // 
            this.lblKeyFile.AutoSize = true;
            this.lblKeyFile.Location = new System.Drawing.Point(3, 55);
            this.lblKeyFile.Name = "lblKeyFile";
            this.lblKeyFile.Size = new System.Drawing.Size(44, 13);
            this.lblKeyFile.TabIndex = 26;
            this.lblKeyFile.Text = "KeyFile:";
            // 
            // txtSshKey
            // 
            this.txtSshKey.Location = new System.Drawing.Point(6, 71);
            this.txtSshKey.Name = "txtSshKey";
            this.txtSshKey.Size = new System.Drawing.Size(295, 20);
            this.txtSshKey.TabIndex = 27;
            // 
            // cmdBrowseKeyFile
            // 
            this.cmdBrowseKeyFile.Location = new System.Drawing.Point(299, 71);
            this.cmdBrowseKeyFile.Name = "cmdBrowseKeyFile";
            this.cmdBrowseKeyFile.Size = new System.Drawing.Size(27, 20);
            this.cmdBrowseKeyFile.TabIndex = 28;
            this.cmdBrowseKeyFile.Text = "...";
            this.cmdBrowseKeyFile.UseVisualStyleBackColor = true;
            this.cmdBrowseKeyFile.Click += new System.EventHandler(this.cmdOpenKeyFile_Click);
            // 
            // chkAutoUpdate
            // 
            this.chkAutoUpdate.AutoSize = true;
            this.chkAutoUpdate.Checked = true;
            this.chkAutoUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoUpdate.Location = new System.Drawing.Point(6, 19);
            this.chkAutoUpdate.Name = "chkAutoUpdate";
            this.chkAutoUpdate.Size = new System.Drawing.Size(207, 17);
            this.chkAutoUpdate.TabIndex = 29;
            this.chkAutoUpdate.Text = "Auto update status every (in seconds):";
            this.chkAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // txtAutoUpdateInt
            // 
            this.txtAutoUpdateInt.Location = new System.Drawing.Point(29, 42);
            this.txtAutoUpdateInt.Mask = "00000";
            this.txtAutoUpdateInt.Name = "txtAutoUpdateInt";
            this.txtAutoUpdateInt.Size = new System.Drawing.Size(47, 20);
            this.txtAutoUpdateInt.TabIndex = 30;
            this.txtAutoUpdateInt.Text = "3";
            this.txtAutoUpdateInt.ValidatingType = typeof(int);
            // 
            // chkClipboardMon
            // 
            this.chkClipboardMon.AutoSize = true;
            this.chkClipboardMon.Location = new System.Drawing.Point(6, 68);
            this.chkClipboardMon.Name = "chkClipboardMon";
            this.chkClipboardMon.Size = new System.Drawing.Size(107, 17);
            this.chkClipboardMon.TabIndex = 31;
            this.chkClipboardMon.Text = "Monitor clipboard";
            this.chkClipboardMon.UseVisualStyleBackColor = true;
            // 
            // grbConnectionSettings
            // 
            this.grbConnectionSettings.Controls.Add(this.cmdTestConnection);
            this.grbConnectionSettings.Controls.Add(this.txtSshHost);
            this.grbConnectionSettings.Controls.Add(this.lblServer);
            this.grbConnectionSettings.Controls.Add(this.lblPort);
            this.grbConnectionSettings.Controls.Add(this.txtSshPort);
            this.grbConnectionSettings.Controls.Add(this.cmdBrowseKeyFile);
            this.grbConnectionSettings.Controls.Add(this.txtSshLogin);
            this.grbConnectionSettings.Controls.Add(this.txtSshKey);
            this.grbConnectionSettings.Controls.Add(this.lblLogin);
            this.grbConnectionSettings.Controls.Add(this.lblKeyFile);
            this.grbConnectionSettings.Controls.Add(this.lblPassword);
            this.grbConnectionSettings.Controls.Add(this.txtSshPass);
            this.grbConnectionSettings.Location = new System.Drawing.Point(12, 12);
            this.grbConnectionSettings.Name = "grbConnectionSettings";
            this.grbConnectionSettings.Size = new System.Drawing.Size(457, 105);
            this.grbConnectionSettings.TabIndex = 32;
            this.grbConnectionSettings.TabStop = false;
            this.grbConnectionSettings.Text = "Connection";
            // 
            // grbCommonSettings
            // 
            this.grbCommonSettings.Controls.Add(this.cmbLanguage);
            this.grbCommonSettings.Controls.Add(this.lblLanguage);
            this.grbCommonSettings.Controls.Add(this.chkAutoUpdate);
            this.grbCommonSettings.Controls.Add(this.txtAutoUpdateInt);
            this.grbCommonSettings.Controls.Add(this.chkClipboardMon);
            this.grbCommonSettings.Location = new System.Drawing.Point(12, 123);
            this.grbCommonSettings.Name = "grbCommonSettings";
            this.grbCommonSettings.Size = new System.Drawing.Size(457, 97);
            this.grbCommonSettings.TabIndex = 33;
            this.grbCommonSettings.TabStop = false;
            this.grbCommonSettings.Text = "Common";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(271, 41);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(180, 21);
            this.cmbLanguage.TabIndex = 33;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(268, 20);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(58, 13);
            this.lblLanguage.TabIndex = 32;
            this.lblLanguage.Text = "Language:";
            // 
            // grbServerSettings
            // 
            this.grbServerSettings.Controls.Add(this.txtFinishedMark);
            this.grbServerSettings.Controls.Add(this.lblFinishedMark);
            this.grbServerSettings.Controls.Add(this.txtRmCmd);
            this.grbServerSettings.Controls.Add(this.lblRmCmd);
            this.grbServerSettings.Controls.Add(this.txtKillCmd);
            this.grbServerSettings.Controls.Add(this.lblKillCmd);
            this.grbServerSettings.Controls.Add(this.txtMkDirCmd);
            this.grbServerSettings.Controls.Add(this.lblMkDirCmd);
            this.grbServerSettings.Controls.Add(this.txtReadLogCmd);
            this.grbServerSettings.Controls.Add(this.lblReadLogCmd);
            this.grbServerSettings.Controls.Add(this.txtPsCmd);
            this.grbServerSettings.Controls.Add(this.lblPsCmd);
            this.grbServerSettings.Controls.Add(this.txtWgetCmd);
            this.grbServerSettings.Controls.Add(this.lblWgetCmd);
            this.grbServerSettings.Location = new System.Drawing.Point(475, 12);
            this.grbServerSettings.Name = "grbServerSettings";
            this.grbServerSettings.Size = new System.Drawing.Size(457, 304);
            this.grbServerSettings.TabIndex = 34;
            this.grbServerSettings.TabStop = false;
            this.grbServerSettings.Text = "Server";
            // 
            // txtFinishedMark
            // 
            this.txtFinishedMark.Location = new System.Drawing.Point(6, 266);
            this.txtFinishedMark.Name = "txtFinishedMark";
            this.txtFinishedMark.Size = new System.Drawing.Size(445, 20);
            this.txtFinishedMark.TabIndex = 13;
            // 
            // lblFinishedMark
            // 
            this.lblFinishedMark.AutoSize = true;
            this.lblFinishedMark.Location = new System.Drawing.Point(3, 250);
            this.lblFinishedMark.Name = "lblFinishedMark";
            this.lblFinishedMark.Size = new System.Drawing.Size(112, 13);
            this.lblFinishedMark.TabIndex = 12;
            this.lblFinishedMark.Text = "Finished marker in log:";
            // 
            // txtRmCmd
            // 
            this.txtRmCmd.Location = new System.Drawing.Point(6, 227);
            this.txtRmCmd.Name = "txtRmCmd";
            this.txtRmCmd.Size = new System.Drawing.Size(445, 20);
            this.txtRmCmd.TabIndex = 11;
            // 
            // lblRmCmd
            // 
            this.lblRmCmd.AutoSize = true;
            this.lblRmCmd.Location = new System.Drawing.Point(3, 211);
            this.lblRmCmd.Name = "lblRmCmd";
            this.lblRmCmd.Size = new System.Drawing.Size(75, 13);
            this.lblRmCmd.TabIndex = 10;
            this.lblRmCmd.Text = "Rm command:";
            // 
            // txtKillCmd
            // 
            this.txtKillCmd.Location = new System.Drawing.Point(6, 188);
            this.txtKillCmd.Name = "txtKillCmd";
            this.txtKillCmd.Size = new System.Drawing.Size(445, 20);
            this.txtKillCmd.TabIndex = 9;
            // 
            // lblKillCmd
            // 
            this.lblKillCmd.AutoSize = true;
            this.lblKillCmd.Location = new System.Drawing.Point(3, 172);
            this.lblKillCmd.Name = "lblKillCmd";
            this.lblKillCmd.Size = new System.Drawing.Size(72, 13);
            this.lblKillCmd.TabIndex = 8;
            this.lblKillCmd.Text = "Kill command:";
            // 
            // txtMkDirCmd
            // 
            this.txtMkDirCmd.Location = new System.Drawing.Point(6, 149);
            this.txtMkDirCmd.Name = "txtMkDirCmd";
            this.txtMkDirCmd.Size = new System.Drawing.Size(445, 20);
            this.txtMkDirCmd.TabIndex = 7;
            // 
            // lblMkDirCmd
            // 
            this.lblMkDirCmd.AutoSize = true;
            this.lblMkDirCmd.Location = new System.Drawing.Point(3, 133);
            this.lblMkDirCmd.Name = "lblMkDirCmd";
            this.lblMkDirCmd.Size = new System.Drawing.Size(85, 13);
            this.lblMkDirCmd.TabIndex = 6;
            this.lblMkDirCmd.Text = "Mkdir command:";
            // 
            // txtReadLogCmd
            // 
            this.txtReadLogCmd.Location = new System.Drawing.Point(6, 110);
            this.txtReadLogCmd.Name = "txtReadLogCmd";
            this.txtReadLogCmd.Size = new System.Drawing.Size(445, 20);
            this.txtReadLogCmd.TabIndex = 5;
            // 
            // lblReadLogCmd
            // 
            this.lblReadLogCmd.AutoSize = true;
            this.lblReadLogCmd.Location = new System.Drawing.Point(3, 94);
            this.lblReadLogCmd.Name = "lblReadLogCmd";
            this.lblReadLogCmd.Size = new System.Drawing.Size(102, 13);
            this.lblReadLogCmd.TabIndex = 4;
            this.lblReadLogCmd.Text = "Read log command:";
            // 
            // txtPsCmd
            // 
            this.txtPsCmd.Location = new System.Drawing.Point(6, 71);
            this.txtPsCmd.Name = "txtPsCmd";
            this.txtPsCmd.Size = new System.Drawing.Size(445, 20);
            this.txtPsCmd.TabIndex = 3;
            // 
            // lblPsCmd
            // 
            this.lblPsCmd.AutoSize = true;
            this.lblPsCmd.Location = new System.Drawing.Point(3, 55);
            this.lblPsCmd.Name = "lblPsCmd";
            this.lblPsCmd.Size = new System.Drawing.Size(71, 13);
            this.lblPsCmd.TabIndex = 2;
            this.lblPsCmd.Text = "Ps command:";
            // 
            // txtWgetCmd
            // 
            this.txtWgetCmd.Location = new System.Drawing.Point(6, 32);
            this.txtWgetCmd.Name = "txtWgetCmd";
            this.txtWgetCmd.Size = new System.Drawing.Size(445, 20);
            this.txtWgetCmd.TabIndex = 1;
            // 
            // lblWgetCmd
            // 
            this.lblWgetCmd.AutoSize = true;
            this.lblWgetCmd.Location = new System.Drawing.Point(3, 16);
            this.lblWgetCmd.Name = "lblWgetCmd";
            this.lblWgetCmd.Size = new System.Drawing.Size(85, 13);
            this.lblWgetCmd.TabIndex = 0;
            this.lblWgetCmd.Text = "Wget command:";
            // 
            // grbServerPath
            // 
            this.grbServerPath.Controls.Add(this.txtLstDir);
            this.grbServerPath.Controls.Add(this.lblLstDir);
            this.grbServerPath.Controls.Add(this.txtLogsDir);
            this.grbServerPath.Controls.Add(this.lblLogsDir);
            this.grbServerPath.Controls.Add(this.txtDownloadsDir);
            this.grbServerPath.Controls.Add(this.lblDownloadsDir);
            this.grbServerPath.Location = new System.Drawing.Point(12, 226);
            this.grbServerPath.Name = "grbServerPath";
            this.grbServerPath.Size = new System.Drawing.Size(457, 142);
            this.grbServerPath.TabIndex = 35;
            this.grbServerPath.TabStop = false;
            this.grbServerPath.Text = "Server path";
            // 
            // txtLstDir
            // 
            this.txtLstDir.Location = new System.Drawing.Point(6, 111);
            this.txtLstDir.Name = "txtLstDir";
            this.txtLstDir.Size = new System.Drawing.Size(445, 20);
            this.txtLstDir.TabIndex = 39;
            // 
            // lblLstDir
            // 
            this.lblLstDir.AutoSize = true;
            this.lblLstDir.Location = new System.Drawing.Point(3, 95);
            this.lblLstDir.Name = "lblLstDir";
            this.lblLstDir.Size = new System.Drawing.Size(37, 13);
            this.lblLstDir.TabIndex = 38;
            this.lblLstDir.Text = "LstDir:";
            // 
            // txtLogsDir
            // 
            this.txtLogsDir.Location = new System.Drawing.Point(6, 72);
            this.txtLogsDir.Name = "txtLogsDir";
            this.txtLogsDir.Size = new System.Drawing.Size(445, 20);
            this.txtLogsDir.TabIndex = 37;
            // 
            // lblLogsDir
            // 
            this.lblLogsDir.AutoSize = true;
            this.lblLogsDir.Location = new System.Drawing.Point(3, 56);
            this.lblLogsDir.Name = "lblLogsDir";
            this.lblLogsDir.Size = new System.Drawing.Size(46, 13);
            this.lblLogsDir.TabIndex = 36;
            this.lblLogsDir.Text = "LogsDir:";
            // 
            // txtDownloadsDir
            // 
            this.txtDownloadsDir.Location = new System.Drawing.Point(6, 33);
            this.txtDownloadsDir.Name = "txtDownloadsDir";
            this.txtDownloadsDir.Size = new System.Drawing.Size(445, 20);
            this.txtDownloadsDir.TabIndex = 1;
            // 
            // lblDownloadsDir
            // 
            this.lblDownloadsDir.AutoSize = true;
            this.lblDownloadsDir.Location = new System.Drawing.Point(3, 16);
            this.lblDownloadsDir.Name = "lblDownloadsDir";
            this.lblDownloadsDir.Size = new System.Drawing.Size(76, 13);
            this.lblDownloadsDir.TabIndex = 0;
            this.lblDownloadsDir.Text = "DownloadsDir:";
            // 
            // cmdTestConnection
            // 
            this.cmdTestConnection.Location = new System.Drawing.Point(345, 58);
            this.cmdTestConnection.Name = "cmdTestConnection";
            this.cmdTestConnection.Size = new System.Drawing.Size(105, 36);
            this.cmdTestConnection.TabIndex = 29;
            this.cmdTestConnection.Text = "Test connection";
            this.cmdTestConnection.UseVisualStyleBackColor = true;
            this.cmdTestConnection.Click += new System.EventHandler(this.cmdTestConnection_Click);
            // 
            // frmSettings
            // 
            this.AcceptButton = this.cmdOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(940, 376);
            this.Controls.Add(this.grbServerPath);
            this.Controls.Add(this.grbServerSettings);
            this.Controls.Add(this.grbCommonSettings);
            this.Controls.Add(this.grbConnectionSettings);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.grbConnectionSettings.ResumeLayout(false);
            this.grbConnectionSettings.PerformLayout();
            this.grbCommonSettings.ResumeLayout(false);
            this.grbCommonSettings.PerformLayout();
            this.grbServerSettings.ResumeLayout(false);
            this.grbServerSettings.PerformLayout();
            this.grbServerPath.ResumeLayout(false);
            this.grbServerPath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtSshHost;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.MaskedTextBox txtSshPort;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtSshLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtSshPass;
        private System.Windows.Forms.Label lblKeyFile;
        private System.Windows.Forms.TextBox txtSshKey;
        private System.Windows.Forms.Button cmdBrowseKeyFile;
        private System.Windows.Forms.CheckBox chkAutoUpdate;
        private System.Windows.Forms.MaskedTextBox txtAutoUpdateInt;
        private System.Windows.Forms.CheckBox chkClipboardMon;
        private System.Windows.Forms.GroupBox grbConnectionSettings;
        private System.Windows.Forms.GroupBox grbCommonSettings;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.GroupBox grbServerSettings;
        private System.Windows.Forms.Label lblWgetCmd;
        private System.Windows.Forms.TextBox txtWgetCmd;
        private System.Windows.Forms.TextBox txtPsCmd;
        private System.Windows.Forms.Label lblPsCmd;
        private System.Windows.Forms.TextBox txtReadLogCmd;
        private System.Windows.Forms.Label lblReadLogCmd;
        private System.Windows.Forms.Label lblMkDirCmd;
        private System.Windows.Forms.TextBox txtMkDirCmd;
        private System.Windows.Forms.TextBox txtKillCmd;
        private System.Windows.Forms.Label lblKillCmd;
        private System.Windows.Forms.Label lblRmCmd;
        private System.Windows.Forms.TextBox txtRmCmd;
        private System.Windows.Forms.TextBox txtFinishedMark;
        private System.Windows.Forms.Label lblFinishedMark;
        private System.Windows.Forms.GroupBox grbServerPath;
        private System.Windows.Forms.Label lblDownloadsDir;
        private System.Windows.Forms.TextBox txtDownloadsDir;
        private System.Windows.Forms.Label lblLogsDir;
        private System.Windows.Forms.TextBox txtLogsDir;
        private System.Windows.Forms.Label lblLstDir;
        private System.Windows.Forms.TextBox txtLstDir;
        private System.Windows.Forms.Button cmdTestConnection;
    }
}