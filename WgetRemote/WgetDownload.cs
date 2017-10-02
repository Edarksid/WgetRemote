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
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;
using Tamir.SharpSsh;

namespace WgetRemote
{
    [Serializable]
    public class WgetDownload
    {        
        private string id;
        private string url;        
        private int pid;
        private string log_name;
        private string list_name;

        public WgetDownload(string url)
        {
            this.id = GenerateRnd();
            this.url = url;
        }

        /// <summary>
        /// This proprerty gets url status.
        /// </summary>
        public string Status
        {
            get
            {
                string result, run;
                run = SshExec(ProgramSettings.settings.PsCmd.Replace("%pid%", pid.ToString()));
                if (run.Length > 0)
                    run = Localization.GetString("Run");
                else
                    run = Localization.GetString("NotRun");
                result = SshExec(ProgramSettings.settings.ReadLogCmd.Replace("%log_name%", log_name));
                return run +" " + result;
            }
        }

        /// <summary>
        /// This method terminate download and delete log. It's NOT delete downloaded file.
        /// </summary>
        public void Terminate()
        {
            SshExec(ProgramSettings.settings.KillCmd.Replace("%pid%", pid.ToString()));
            SshExec(ProgramSettings.settings.RmCmd.Replace("%log_name%", log_name).Replace("%list_name%", list_name));            
            return;
        }

        /// <summary>
        /// This method only terminate download process.
        /// </summary>
        public void Stop()
        {
            SshExec("kill -9  " + pid.ToString());
            return;
        }

        /// <summary>
        /// This proprerty gets Ulr(s).
        /// </summary>
        public string Url
        {
            get { return url; }
        }

        /// <summary>
        /// This method start download and return pair url and its status.
        /// </summary>
        public string[] Start()
        {
            string[] UrlState = new string[2];
            string result,str;
            int p1;
            UrlState[0] = url.Replace("\r\n", ";");
            string local_list="wget-" + id + ".lst";
            list_name = ProgramSettings.settings.LstDir + "/" + local_list;
            log_name = ProgramSettings.settings.LogsDir + "/wget-" + id + ".log";
            StreamWriter writer = new StreamWriter(local_list);
            writer.Write(url);
            writer.Close();
            SshExec(ProgramSettings.settings.MkDirCmd.Replace("%download_dir%", ProgramSettings.settings.DownloadsDir).
                    Replace("%log_dir%", ProgramSettings.settings.LogsDir).
                    Replace("%lst_dir%", ProgramSettings.settings.LstDir));                
            UploadFile(local_list);
            try
            {
                File.Delete(local_list);
            }
            catch {};
            string wget_cmd = ProgramSettings.settings.WgetCmd;
            wget_cmd = wget_cmd.Replace("%list_name%",list_name).
                Replace("%log_name%", log_name).
                Replace("%downloads_dir%", ProgramSettings.settings.DownloadsDir);            
            result=SshExec(wget_cmd);
            p1= result.IndexOf("pid");
            try
            {
                str = result.Substring(p1 + 4, result.Length - p1 - 4 - 2);
                pid = int.Parse(str);
            }
            catch (Exception e)
            {
                string error_msg=Localization.GetString("WgetError").
                    Replace("%error%",e.Message).Replace("%wget_cmd%",wget_cmd).Replace("%result%",result);
                MessageBox.Show(error_msg, "Wget Remote", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1, 0);
                UrlState[1] = Constants.pid_error;
                return UrlState;
            }            
            UrlState[1] = Localization.GetString("WgetStarted").Replace("%pid%", pid.ToString()).Replace("%log_name%",log_name);
            return UrlState;
        }

        private void UploadFile(string fname)
        {
            SshTransferProtocolBase sshCp=null;
            if (ProgramSettings.settings.SshKey.Length == 0)
                sshCp = new Scp(ProgramSettings.settings.SshHost, ProgramSettings.settings.SshLogin, ProgramSettings.settings.SshPass);
            else
            {
                try
                {
                    sshCp = new Scp(ProgramSettings.settings.SshHost, ProgramSettings.settings.SshLogin);
                    if (ProgramSettings.settings.SshPass.Length == 0)
                        sshCp.AddIdentityFile(ProgramSettings.settings.SshKey);
                    else
                        sshCp.AddIdentityFile(ProgramSettings.settings.SshKey, ProgramSettings.settings.SshPass);
                }
                catch{}
            }
            sshCp.Connect(ProgramSettings.settings.SshPort);
            sshCp.Put(fname, ProgramSettings.settings.LstDir + "/" + fname);
            sshCp.Close();
            return;
        }

        private string GenerateRnd()
        {
            int size = 8 * 3 / 4;
            byte[] rnd = new byte[size];
            RandomNumberGenerator.Create().GetBytes(rnd);
            string random = Convert.ToBase64String(rnd, 0, rnd.Length);
            Array.Clear(rnd, 0, rnd.Length);
            random = random.Replace("/", "a");
            random = random.Replace("+", "h");
            return random;
        }

        private string SshExec(string ssh_cmd)
        {
            string result = ""; 
            SshExec exec=null;
            if (ProgramSettings.settings.SshKey.Length == 0)
                exec = new SshExec(ProgramSettings.settings.SshHost, ProgramSettings.settings.SshLogin, ProgramSettings.settings.SshPass);            
            else
            {
                try
                {
                    exec = new SshExec(ProgramSettings.settings.SshHost, ProgramSettings.settings.SshLogin);
                    if (ProgramSettings.settings.SshPass.Length == 0)
                        exec.AddIdentityFile(ProgramSettings.settings.SshKey);
                    else
                        exec.AddIdentityFile(ProgramSettings.settings.SshKey, ProgramSettings.settings.SshPass);
                }
                catch { }
            }
            exec.Connect(ProgramSettings.settings.SshPort);
            result = exec.RunCommand(ssh_cmd).Replace("\n", " ");            
            exec.Close();
            return result;
        }
    }
}
