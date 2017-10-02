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
using System.Resources;
using System.Windows.Forms;

namespace WgetRemote
{
    public static class Localization
    {        
        private static ResXResourceSet lng_res= new ResXResourceSet(Constants.lng_folder + "\\" + 
            ProgramSettings.settings.Language + ".resx");

        public static string GetString(string name)
        {
            string res = lng_res.GetString(name);            
            return res;
        }

        private static void LocalizateOneControl(Control ctrl)
        {
            string local = GetString(ctrl.Name.Substring(3));
            if (local != null)
            {
                ctrl.Text = local;
            }
        }

        private static void LocalizateMenuItem(ToolStripMenuItem mnu)
        {
            string local = GetString(mnu.Name.Substring(3));
            if (local != null)
            {
                mnu.Text = local;
            }
            local = GetString(mnu.Name.Substring(3)+"ToolTip");
            if (local != null)
            {
                mnu.ToolTipText = local;
            }
        }

        public static void LocalizateMenu(ContextMenuStrip menu)
        {
            foreach (ToolStripMenuItem mnu in menu.Items)
            {
                LocalizateMenuItem(mnu);
            }
        }

        public static void LocalizateForm(Control container)
        {            
            LocalizateOneControl(container);
            foreach (Control ctrl in container.Controls)
            {
                if (ctrl is Label || ctrl is CheckBox || ctrl is ComboBox || ctrl is Button )
                {
                    LocalizateOneControl(ctrl);                    
                }
                if (ctrl is GroupBox)
                {
                    LocalizateForm(ctrl);
                }
            }
        }

        public static void LoadLanguage()
        {
                lng_res = new ResXResourceSet(Constants.lng_folder + "\\" + ProgramSettings.settings.Language + ".resx");            
        }

    }
}
