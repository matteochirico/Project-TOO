using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_TOO
{
    public static class ProjectController
    {
        private static string _displayName;
        public static string DisplayName
        {
            get { return _displayName; }
        }

        public static void SetDisplayName(string name)
        {
            if (!File.Exists("username"))
            {
                StreamWriter writer = new StreamWriter("username");
                writer.Write(name);
                writer.Flush();
                writer.Close();
                _displayName = name;
            }
            else
            {
                StreamWriter writer = new StreamWriter("username");
                writer.Write(name);
                writer.Flush();
                writer.Close();
                _displayName = name;
            }

            MainForm.SetDisplayName(DisplayName);
        }

        public static void GetDisplayName()
        {

        }
    }
}
