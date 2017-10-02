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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;

namespace WgetRemote
{
    public static class Serializer
    {
        public static void UpdateObjectByFile(object obj,string fname)
        {
            object state = Serializer.LoadFromFile(fname);
            if (state != null)
            {
                foreach (FieldInfo field in state.GetType().GetFields())
                {
                    object value = field.GetValue(state);
                    if (value != null)
                    {
                        field.SetValue(obj, value);
                    }
                }
            }   
        }
        private static object LoadFromFile(string fname)
        {
            MemoryStream buf = new MemoryStream();
            BinaryFormatter stateForm = new BinaryFormatter();
            byte[] state_bytes = null;
            if (!File.Exists(fname))
            {
                return null;
            }
            StreamReader reader = new StreamReader(fname);
            state_bytes = Encoding.Default.GetBytes(reader.ReadToEnd());
            reader.Close();
            buf.Write(state_bytes, 0, state_bytes.Length);
            buf.Position = 0;
            return stateForm.Deserialize(buf);
        }

        public static void SaveToFile(object obj, string fname)
        {
            byte[] state_ser = null;
            MemoryStream buf = new MemoryStream();
            BinaryFormatter stateForm = new BinaryFormatter();
            stateForm.Serialize(buf, obj);
            buf.Position = 0;
            state_ser = buf.ToArray();
            StreamWriter writer = new StreamWriter(fname);
            writer.Write(Encoding.Default.GetString(state_ser));
            writer.Close();
        }
    }
}
