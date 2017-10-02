/* 
    Copyright © Rozenbaum Danil 2010-2017
    This file is part of WgetRemote.

    WgetRemote is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    WgetRemote is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with WgetRemote.  If not, see <http://www.gnu.org/licenses/>.*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WgetRemote
{
    public partial class frmMain : Form
    {
        private ProgramState state;

        public frmMain()
        {
            InitializeComponent();
            ProgramSettings.settings = new ProgramSettings();
            Localization.LoadLanguage();
            LocalizateForm();
            LoadState();
        }

        private void LocalizateForm()
        {
            Localization.LocalizateForm(this);
            Localization.LocalizateMenu(contextMenuDownload);
            Localization.LocalizateMenu(contextMenuTray);            
            colUrl.Text = Localization.GetString("Url");
            colStatus.Text = Localization.GetString("Status");         
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void Exit()
        {
            timAutoUpdate.Enabled = false;
            if (backgroundAutoUpdate.IsBusy)
            {
                backgroundAutoUpdate.CancelAsync();
                Thread.Sleep(500);
            }
            
            SaveState();
            Application.Exit();
         
        }

        private void SaveState()
        {
            state.SetDownloads(lstDowndloads);
            Serializer.SaveToFile(state, Constants.state_file);            
        }

        private void AddDownloadBack()
        {
            foreach (string str in txtUrls.Lines)
            { 
                AddDownloadTask(str);
            }
            txtUrls.Clear();            
            return;
        }

        private void AddAsQueueBack()
        {   
            AddDownloadTask(txtUrls.Text);
            txtUrls.Clear();
            return;
        }

        private void AddDownloadTask(string url)
        {
            if (url.Length > 0)
            {
                BackgroundWorker bwAddDld = new BackgroundWorker();
                bwAddDld.DoWork += new System.ComponentModel.DoWorkEventHandler(bwAddDownloadDoWork);
                bwAddDld.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(bwAddDownloadCompleted);
                bwAddDld.RunWorkerAsync(url);
            }
        }

        public void bwAddDownloadDoWork(object sender, DoWorkEventArgs e)
        {
                string[] urlstatus;
                WgetDownload wgetd = new WgetDownload((string)e.Argument);
                urlstatus = wgetd.Start();
                object[] res = new object[2];
                res[0] = urlstatus;
                res[1] = wgetd;
                e.Result = res;            
        }
        
        private void bwAddDownloadCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
                string[] urlstatus = (string[])((object[])e.Result)[0];
                WgetDownload wgetd = (WgetDownload)((object[])e.Result)[1];
                if (urlstatus[1] != Constants.pid_error)
                {
                    ListViewItem download = new ListViewItem(urlstatus);
                    download.Tag = wgetd;
                    if (download.SubItems[0].Text.Length > download.SubItems[1].Text.Length + 3)
                        download.SubItems[0].Text = download.SubItems[0].Text.Substring(0, download.SubItems[1].Text.Length) + "...";                    
                    download.ToolTipText = wgetd.Url;
                    lstDowndloads.Items.Add(download);
                    lstDowndloads.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
                SetColors();
                return;
        }

        private void lstDowndloads_DoubleClick(object sender, EventArgs e)
        {
            UpdateStatus(lstDowndloads.SelectedItems[0]);
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstDowndloads.SelectedItems.Count == 0) return;
            UpdateStatus(lstDowndloads.SelectedItems[0]);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstDowndloads.SelectedItems.Count == 0) return;
            ((WgetDownload)lstDowndloads.SelectedItems[0].Tag).Terminate();
            lstDowndloads.SelectedItems[0].Remove();
        }

        private void timAutoUpdate_Tick(object sender, EventArgs e)
        {
            if (backgroundAutoUpdate.IsBusy) return;
            AutoUpdateStatus();
        }

        private void UpdateStatus(ListViewItem download)
        {
            if (backgroundStatus.IsBusy) return;
            backgroundStatus.RunWorkerAsync(download);
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            AddDownloadBack();
        }

        private void backgroundStatus_DoWork(object sender, DoWorkEventArgs e)
        {
            string back_state;
            back_state=((WgetDownload)((ListViewItem)e.Argument).Tag).Status;
            object[] res =new object[2];
            res[0]=e.Argument;
            res[1]=back_state;
            e.Result = res;
        }

        private void backgroundStatus_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ((ListViewItem)((object[])e.Result)[0]).SubItems[1].Text=(string)((object[])e.Result)[1];
            ListViewItem download = ((ListViewItem)((object[])e.Result)[0]);
            string url = ((WgetDownload)download.Tag).Url.Replace("\r\n", ";");
            if (url.Length > download.SubItems[1].Text.Length + 3)
                download.SubItems[0].Text = url.Substring(0, download.SubItems[1].Text.Length) + "...";            
            lstDowndloads.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            SetColors();
            return;
        }

        private void LoadState()
        {            
            WgetDownload[] wgets;
            string[,] urlstates;
            string[] urlstat=new string[2];
            int count, i;
            ListViewItem download;
            state = new ProgramState();
            txtUrls.Text = state.urls;
            timAutoUpdate.Enabled = ProgramSettings.settings.AutoUpdate;
            timAutoUpdate.Interval = ProgramSettings.settings.AutoUpdateInt * 1000;
            if (ProgramSettings.settings.ClipboardMon)
            {
                ClipboardMonitor.ClipboardUpdate += new EventHandler(ClipboardMonitor_ClipboardUpdate);
            }
            else
            {
                ClipboardMonitor.ClipboardUpdate -= ClipboardMonitor_ClipboardUpdate;
            }

            if (state.wgets != null)
            {
                wgets = state.wgets;
                urlstates = state.urlstates;
                count = wgets.Length;
                for (i = 0; i < count; i++)
                {
                    urlstat[0] = urlstates[0, i];
                    urlstat[1] = urlstates[1, i];
                    download = new ListViewItem(urlstat);
                    download.Tag = wgets[i];
                    lstDowndloads.Items.Add(download);
                    lstDowndloads.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }
            return;
        }
        
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetColors();
        }

        private void AutoUpdateStatus()
        {
            if (backgroundAutoUpdate.IsBusy) return;
            ListViewItem[] items=new ListViewItem[lstDowndloads.Items.Count];
            int i;
            for (i = 0; i < lstDowndloads.Items.Count; i++)
            {
                items[i] = lstDowndloads.Items[i];
            }

            backgroundAutoUpdate.RunWorkerAsync(items);
            return;
        }

        private void backgroundAutoUpdate_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string new_status = (string)((object[])e.UserState)[1];
            if (((ListViewItem)((object[])e.UserState)[0]).SubItems[1].Text != new_status)
            {
                ((ListViewItem)((object[])e.UserState)[0]).SubItems[1].Text = new_status;
                lstDowndloads.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                ListViewItem download = ((ListViewItem)((object[])e.UserState)[0]);
                string url = ((WgetDownload)download.Tag).Url.Replace("\r\n", ";");
                if (url.Length > download.SubItems[1].Text.Length + 3)
                    download.SubItems[0].Text = url.Substring(0, download.SubItems[1].Text.Length) + "...";
                lstDowndloads.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                SetColors();
            }
            return;
        }

        private void backgroundAutoUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
            string back_state;
            object[] res = new object[2];
            foreach (ListViewItem download in ((ListViewItem[])e.Argument))
            {
                if (backgroundAutoUpdate.CancellationPending)
                {
                    return;
                }
                back_state = ((WgetDownload)download.Tag).Status;
                res[0] = download;
                res[1] = back_state;
                backgroundAutoUpdate.ReportProgress(1, res);
            }

            return;
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstDowndloads.SelectedItems.Count == 0) return;
            ListViewItem download = lstDowndloads.SelectedItems[0];
            ((WgetDownload)download.Tag).Stop();
            download.SubItems[1].Text = ((WgetDownload)download.Tag).Status;            
            if (((WgetDownload)download.Tag).Url.Length > download.SubItems[1].Text.Length + 3)
                download.SubItems[0].Text = ((WgetDownload)download.Tag).Url.Substring(0, download.SubItems[1].Text.Length) + "...";
            lstDowndloads.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            SetColors();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (lstDowndloads.SelectedItems.Count == 0) return;
            ListViewItem download = lstDowndloads.SelectedItems[0];
            ((WgetDownload)download.Tag).Stop();
            download.SubItems[1].Text = ((WgetDownload)download.Tag).Start()[1];
            string url = ((WgetDownload)download.Tag).Url.Replace("\r\n", ";");
            if (url.Length > download.SubItems[1].Text.Length + 3)
                download.SubItems[0].Text = url.Substring(0, download.SubItems[1].Text.Length) + "...";
            lstDowndloads.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            SetColors();
        }

        private void cmdAddAsQueue_Click(object sender, EventArgs e)
        { 
            AddAsQueueBack();
        }        

        private void SetColors()
        {
            foreach (ListViewItem item in lstDowndloads.Items)
            {
                item.BackColor = Color.Yellow;
                if (item.SubItems[1].Text.Contains(Localization.GetString("Run")))
                    item.BackColor = Color.LightBlue;
                if (item.SubItems[1].Text.Contains(Localization.GetString("NotRun")))
                {
                    if (item.SubItems[1].Text.Contains(ProgramSettings.settings.FinishedMark))
                    {
                        item.BackColor = Color.SpringGreen;
                    }
                    else
                    {
                        item.BackColor = Color.Red;
                    }
                }
            }
            lstDowndloads.Refresh();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            this.Activate();     

        }

        private void ClipboardMonitor_ClipboardUpdate(object sender, EventArgs e)
        {
            string urls="";
            foreach (string line in Clipboard.GetText().Split("\n".ToCharArray()))
            {
                if (line.ToLower().StartsWith("http://") ||
                    line.ToLower().StartsWith("https://") ||
                    line.ToLower().StartsWith("ftp://"))
                {
                    urls += line.Replace("\r", "") + "\r\n";
                    if (txtUrls.Text.Length == 0 || txtUrls.Text.EndsWith("\r\n"))
                    {
                        txtUrls.AppendText(line.Replace("\r", ""));
                    }
                    else
                    {
                        txtUrls.AppendText("\r\n"+line.Replace("\r", ""));
                    }
                }
            }
            if (urls.Length > 0)
            {
                notifyIcon.ShowBalloonTip(1500, Localization.GetString("ClipboardUrls"), urls.TrimEnd("\r\n".ToCharArray()), ToolTipIcon.Info);
            }
           
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                this.ShowInTaskbar = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void cmdSettings_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }

        private void ShowSettings()
        {
            frmSettings settings = new frmSettings();
            if (settings.ShowDialog() == DialogResult.OK)
            {
                LocalizateForm();
            }
        }

        private void mnuCopyStatus_Click(object sender, EventArgs e)
        {
            if (lstDowndloads.SelectedItems.Count == 0) return;
            ListViewItem download = lstDowndloads.SelectedItems[0];
            string status = lstDowndloads.SelectedItems[0].SubItems[1].Text;
            Clipboard.SetText(status);
        }        
    }
}
