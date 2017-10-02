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

namespace WgetRemote
{
    [Serializable]
    public class ProgramState
    {
        public string urls = null;
        public WgetDownload[] wgets = null;
        public string[,] urlstates = null;

        public ProgramState()
        {
            Serializer.UpdateObjectByFile(this, Constants.state_file);
        }

        public void SetDownloads(ListView downloadlst)
        {
            int count, i;
            count = downloadlst.Items.Count;
            wgets = new WgetDownload[count];
            urlstates = new string[2, count];
            for (i = 0; i < count; i++)
            {
                wgets[i] = (WgetDownload)downloadlst.Items[i].Tag;
                urlstates[0, i] = downloadlst.Items[i].SubItems[0].Text;
                urlstates[1, i] = downloadlst.Items[i].SubItems[1].Text;
            }
        }
    }
}
