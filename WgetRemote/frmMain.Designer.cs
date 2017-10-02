namespace WgetRemote
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lstDowndloads = new System.Windows.Forms.ListView();
            this.colUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuDownload = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuStatusMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStopMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRestartMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopyStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUrls = new System.Windows.Forms.TextBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.lblUrls = new System.Windows.Forms.Label();
            this.timAutoUpdate = new System.Windows.Forms.Timer(this.components);
            this.backgroundStatus = new System.ComponentModel.BackgroundWorker();
            this.backgroundAutoUpdate = new System.ComponentModel.BackgroundWorker();
            this.cmdAddAsQueue = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdShowSettings = new System.Windows.Forms.Button();
            this.sptContaiter = new System.Windows.Forms.SplitContainer();
            this.contextMenuDownload.SuspendLayout();
            this.contextMenuTray.SuspendLayout();
            this.sptContaiter.Panel1.SuspendLayout();
            this.sptContaiter.Panel2.SuspendLayout();
            this.sptContaiter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDowndloads
            // 
            this.lstDowndloads.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUrl,
            this.colStatus});
            this.lstDowndloads.ContextMenuStrip = this.contextMenuDownload;
            this.lstDowndloads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDowndloads.FullRowSelect = true;
            this.lstDowndloads.GridLines = true;
            this.lstDowndloads.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstDowndloads.Location = new System.Drawing.Point(0, 0);
            this.lstDowndloads.MultiSelect = false;
            this.lstDowndloads.Name = "lstDowndloads";
            this.lstDowndloads.Scrollable = false;
            this.lstDowndloads.ShowItemToolTips = true;
            this.lstDowndloads.Size = new System.Drawing.Size(753, 251);
            this.lstDowndloads.TabIndex = 6;
            this.lstDowndloads.UseCompatibleStateImageBehavior = false;
            this.lstDowndloads.View = System.Windows.Forms.View.Details;
            this.lstDowndloads.DoubleClick += new System.EventHandler(this.lstDowndloads_DoubleClick);
            // 
            // colUrl
            // 
            this.colUrl.Text = "Url";
            this.colUrl.Width = 446;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 83;
            // 
            // contextMenuDownload
            // 
            this.contextMenuDownload.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStatusMenu,
            this.mnuStopMenu,
            this.mnuRestartMenu,
            this.mnuRemoveMenu,
            this.mnuCopyStatus});
            this.contextMenuDownload.Name = "contextMenuDownload";
            this.contextMenuDownload.Size = new System.Drawing.Size(192, 136);
            // 
            // mnuStatusMenu
            // 
            this.mnuStatusMenu.Name = "mnuStatusMenu";
            this.mnuStatusMenu.Size = new System.Drawing.Size(191, 22);
            this.mnuStatusMenu.Text = "&Status";
            this.mnuStatusMenu.ToolTipText = "Update download status";
            this.mnuStatusMenu.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // mnuStopMenu
            // 
            this.mnuStopMenu.Name = "mnuStopMenu";
            this.mnuStopMenu.Size = new System.Drawing.Size(191, 22);
            this.mnuStopMenu.Text = "Sto&p";
            this.mnuStopMenu.ToolTipText = "Stop download";
            this.mnuStopMenu.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // mnuRestartMenu
            // 
            this.mnuRestartMenu.Name = "mnuRestartMenu";
            this.mnuRestartMenu.Size = new System.Drawing.Size(191, 22);
            this.mnuRestartMenu.Text = "Rest&art";
            this.mnuRestartMenu.ToolTipText = "Restart download";
            this.mnuRestartMenu.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // mnuRemoveMenu
            // 
            this.mnuRemoveMenu.Name = "mnuRemoveMenu";
            this.mnuRemoveMenu.Size = new System.Drawing.Size(191, 22);
            this.mnuRemoveMenu.Text = "&Remove";
            this.mnuRemoveMenu.ToolTipText = "Stop download, delete logfile, listfile on server and remove it from local list.";
            this.mnuRemoveMenu.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // mnuCopyStatus
            // 
            this.mnuCopyStatus.Name = "mnuCopyStatus";
            this.mnuCopyStatus.Size = new System.Drawing.Size(191, 22);
            this.mnuCopyStatus.Text = "Copy status to clipboard";
            this.mnuCopyStatus.Click += new System.EventHandler(this.mnuCopyStatus_Click);
            // 
            // txtUrls
            // 
            this.txtUrls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUrls.Location = new System.Drawing.Point(0, 0);
            this.txtUrls.Multiline = true;
            this.txtUrls.Name = "txtUrls";
            this.txtUrls.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUrls.Size = new System.Drawing.Size(753, 255);
            this.txtUrls.TabIndex = 7;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdAdd.Location = new System.Drawing.Point(12, 546);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(135, 28);
            this.cmdAdd.TabIndex = 8;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExit.Location = new System.Drawing.Point(630, 546);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(135, 28);
            this.cmdExit.TabIndex = 9;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // lblUrls
            // 
            this.lblUrls.AutoSize = true;
            this.lblUrls.Location = new System.Drawing.Point(9, 14);
            this.lblUrls.Name = "lblUrls";
            this.lblUrls.Size = new System.Drawing.Size(52, 13);
            this.lblUrls.TabIndex = 10;
            this.lblUrls.Text = "URLs list:";
            // 
            // timAutoUpdate
            // 
            this.timAutoUpdate.Tick += new System.EventHandler(this.timAutoUpdate_Tick);
            // 
            // backgroundStatus
            // 
            this.backgroundStatus.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundStatus_DoWork);
            this.backgroundStatus.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundStatus_RunWorkerCompleted);
            // 
            // backgroundAutoUpdate
            // 
            this.backgroundAutoUpdate.WorkerReportsProgress = true;
            this.backgroundAutoUpdate.WorkerSupportsCancellation = true;
            this.backgroundAutoUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundAutoUpdate_DoWork);
            this.backgroundAutoUpdate.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundAutoUpdate_ProgressChanged);
            // 
            // cmdAddAsQueue
            // 
            this.cmdAddAsQueue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdAddAsQueue.Location = new System.Drawing.Point(323, 546);
            this.cmdAddAsQueue.Name = "cmdAddAsQueue";
            this.cmdAddAsQueue.Size = new System.Drawing.Size(135, 28);
            this.cmdAddAsQueue.TabIndex = 14;
            this.cmdAddAsQueue.Text = "Add as queue";
            this.cmdAddAsQueue.UseVisualStyleBackColor = true;
            this.cmdAddAsQueue.Click += new System.EventHandler(this.cmdAddAsQueue_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.ContextMenuStrip = this.contextMenuTray;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Wget Remote";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuTray
            // 
            this.contextMenuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExitMenu});
            this.contextMenuTray.Name = "contextMenuTray";
            this.contextMenuTray.Size = new System.Drawing.Size(93, 26);
            // 
            // mnuExitMenu
            // 
            this.mnuExitMenu.Name = "mnuExitMenu";
            this.mnuExitMenu.Size = new System.Drawing.Size(92, 22);
            this.mnuExitMenu.Text = "E&xit";
            this.mnuExitMenu.ToolTipText = "Close application";
            this.mnuExitMenu.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cmdShowSettings
            // 
            this.cmdShowSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdShowSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdShowSettings.BackgroundImage")));
            this.cmdShowSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdShowSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdShowSettings.Location = new System.Drawing.Point(741, 3);
            this.cmdShowSettings.Name = "cmdShowSettings";
            this.cmdShowSettings.Size = new System.Drawing.Size(24, 24);
            this.cmdShowSettings.TabIndex = 21;
            this.cmdShowSettings.UseVisualStyleBackColor = true;
            this.cmdShowSettings.Click += new System.EventHandler(this.cmdSettings_Click);
            // 
            // sptContaiter
            // 
            this.sptContaiter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sptContaiter.Location = new System.Drawing.Point(12, 30);
            this.sptContaiter.Name = "sptContaiter";
            this.sptContaiter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sptContaiter.Panel1
            // 
            this.sptContaiter.Panel1.Controls.Add(this.txtUrls);
            // 
            // sptContaiter.Panel2
            // 
            this.sptContaiter.Panel2.Controls.Add(this.lstDowndloads);
            this.sptContaiter.Size = new System.Drawing.Size(753, 510);
            this.sptContaiter.SplitterDistance = 255;
            this.sptContaiter.TabIndex = 22;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 580);
            this.Controls.Add(this.sptContaiter);
            this.Controls.Add(this.cmdShowSettings);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmdAddAsQueue);
            this.Controls.Add(this.lblUrls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wget Remote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.contextMenuDownload.ResumeLayout(false);
            this.contextMenuTray.ResumeLayout(false);
            this.sptContaiter.Panel1.ResumeLayout(false);
            this.sptContaiter.Panel1.PerformLayout();
            this.sptContaiter.Panel2.ResumeLayout(false);
            this.sptContaiter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstDowndloads;
        private System.Windows.Forms.ColumnHeader colUrl;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.TextBox txtUrls;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Label lblUrls;
        private System.Windows.Forms.ContextMenuStrip contextMenuDownload;
        private System.Windows.Forms.ToolStripMenuItem mnuStatusMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuStopMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveMenu;
        private System.Windows.Forms.Timer timAutoUpdate;
        private System.ComponentModel.BackgroundWorker backgroundStatus;
        private System.ComponentModel.BackgroundWorker backgroundAutoUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuRestartMenu;
        private System.Windows.Forms.Button cmdAddAsQueue;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuTray;
        private System.Windows.Forms.ToolStripMenuItem mnuExitMenu;
        private System.Windows.Forms.Button cmdShowSettings;
        private System.Windows.Forms.ToolStripMenuItem mnuCopyStatus;
        private System.Windows.Forms.SplitContainer sptContaiter;
    }
}

