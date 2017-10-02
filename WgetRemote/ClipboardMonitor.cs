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
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WgetRemote
{
    public class ClipboardMonitor
    {
        [DllImport("User32.dll")]
        protected static extern int SetClipboardViewer(int hWndNewViewer);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        static IntPtr nextClipboardViewer;

        /// <summary>
        /// Occurs when the contents of the clipboard is updated.
        /// </summary>
        public static event EventHandler ClipboardUpdate;

        private static NotificationForm _form = new NotificationForm();

        /// <summary>
        /// Raises the <see cref="ClipboardUpdate"/> event.
        /// </summary>
        /// <param name="e">Event arguments for the event.</param>
        private static void OnClipboardUpdate(EventArgs e)
        {
            var handler = ClipboardUpdate;
            if (handler != null)
            {
                handler(null, e);
            }
        }

        public ClipboardMonitor(int form_handle)
        {
            nextClipboardViewer = (IntPtr)SetClipboardViewer(form_handle);
        }

        /// <summary>
        /// Hidden form to recieve the WM_CLIPBOARDUPDATE message.
        /// </summary>
        private class NotificationForm : Form
        {
            public NotificationForm()
            {
                nextClipboardViewer = (IntPtr)SetClipboardViewer((int)this.Handle);
            }

            protected override void WndProc(ref System.Windows.Forms.Message m)
            {
                // defined in winuser.h
                const int WM_DRAWCLIPBOARD = 0x308;
                const int WM_CHANGECBCHAIN = 0x030D;

                switch (m.Msg)
                {
                    case WM_DRAWCLIPBOARD:
                        OnClipboardUpdate(null);
                        SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                        break;
                    case WM_CHANGECBCHAIN:
                        if (m.WParam == nextClipboardViewer)
                            nextClipboardViewer = m.LParam;
                        else
                            SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                        break;
                    default:
                        base.WndProc(ref m);
                        break;
                }
            }


        }

    }
}
