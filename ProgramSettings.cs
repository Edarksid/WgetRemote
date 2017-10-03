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
using System.Windows.Forms;
using System.Reflection;

namespace WgetRemote
{
    [Serializable]
    public class ProgramSettings
    {
        public static ProgramSettings settings; 

        public string SshHost="";
        public string SshLogin = "";
        public string SshPass = "";
        public string SshKey = "";
        public int SshPort = 22;
        public bool AutoUpdate = false;
        public int AutoUpdateInt = 5;
        public bool ClipboardMon = false;
        public string Language = "English";
        public string WgetCmd = "wget -P %downloads_dir% -i %list_name% -b -c --tries=0 --retry-connrefused -o %log_name%";
        public string PsCmd = "ps aux | grep %pid% | grep -v grep";
        public string ReadLogCmd = "tail -n 1 %log_name%";
        public string MkDirCmd = "mkdir -p %download_dir%;mkdir -p %log_dir%;mkdir -p %lst_dir%";
        public string KillCmd = "kill -9 %pid%";
        public string RmCmd = "rm -f %log_name% %list_name%";
        public string FinishedMark = "Downloaded";
        public string DownloadsDir ="downloads";
        public string LogsDir="wgetlogs";
        public string LstDir = "wgetlogs";

        public ProgramSettings()
        {
            Serializer.UpdateObjectByFile(this, Constants.conf_file);
        }

        public void SetToForm(Control container)
        {
            foreach (Control ctrl in container.Controls)
            {
                if (ctrl is GroupBox)
                {
                    SetToForm(ctrl);
                }
                object value=GetFieldValue(ctrl);
                if (value != null)
                {
                    if (ctrl is TextBox)
                    {
                        ctrl.Text = (string)value;
                    }
                    if (ctrl is MaskedTextBox)
                    {
                        ctrl.Text = ((int)value).ToString();
                    }
                    if (ctrl is CheckBox)
                    {
                        ((CheckBox)ctrl).Checked =(bool)value;
                    }
                    if (ctrl is ComboBox)
                    {
                        int idx;
                        idx = ((ComboBox)ctrl).Items.IndexOf((string)value);
                        ((ComboBox)ctrl).SelectedIndex = idx;
                    }
                }
            }
        }

        public void LoadFromForm(Control container)
        {
            foreach (Control ctrl in container.Controls)
            {
                if (ctrl is GroupBox)
                {
                    LoadFromForm(ctrl);
                }
                object value = null;
                if (ctrl is TextBox)
                {
                    value = ctrl.Text;
                }
                if (ctrl is MaskedTextBox)
                {
                    value = int.Parse(ctrl.Text);
                }
                if (ctrl is CheckBox)
                {
                    value = ((CheckBox)ctrl).Checked;
                }
                if (ctrl is ComboBox)
                {
                    value = ((ComboBox)ctrl).SelectedItem.ToString();
                }
                if (value != null)
                {
                    SetFieldValue(ctrl, value);
                }
            }
        }

        private void SetFieldValue(Control ctrl, object value)
        {
            string field_name = ctrl.Name.Substring(3);            
            FieldInfo field = this.GetType().GetField(field_name);
            if (field != null)
            {
                field.SetValue(this, value);
            }
        }

        private object GetFieldValue(Control ctrl)
        {
            string field_name = ctrl.Name.Substring(3);
            object value=null;
            FieldInfo field = this.GetType().GetField(field_name);
            if (field != null)
            {
                value = field.GetValue(this);
            }
            return value;
        }        

    }
}
