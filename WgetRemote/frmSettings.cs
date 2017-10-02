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
using System.IO;

namespace WgetRemote
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();        
            FillLngs();
            LoadSettings();
            Localization.LocalizateForm(this);
        }

        private void LoadSettings()
        {
            ProgramSettings.settings.SetToForm(this);
        }

        private void SaveSettings()
        {
            ProgramSettings.settings.LoadFromForm(this);
            Localization.LoadLanguage();
            Serializer.SaveToFile(ProgramSettings.settings, Constants.conf_file);
            return;
        }

        private void FillLngs()
        {
            DirectoryInfo lng_dinfo = new DirectoryInfo(Constants.lng_folder);

            foreach (FileInfo lng_file in lng_dinfo.GetFiles("*.resx", SearchOption.TopDirectoryOnly))
            {
                cmbLanguage.Items.Add(lng_file.Name.Substring(0,lng_file.Name.Length-5));
            }
        }

        private void SelectKeyFile()
        {
            OpenFileDialog opendlgFileKey = new OpenFileDialog();
            opendlgFileKey.Filter = "*.*|*.*";
            opendlgFileKey.Title = Localization.GetString("OpenKeyFile");
            opendlgFileKey.FileName = txtSshKey.Text;
            opendlgFileKey.ShowDialog();
            txtSshKey.Text = opendlgFileKey.FileName;
            return;
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdOpenKeyFile_Click(object sender, EventArgs e)
        {
            SelectKeyFile();
        }
    }
}
