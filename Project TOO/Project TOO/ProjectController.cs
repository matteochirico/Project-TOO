using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_TOO
{
    public class ProjectController
    {
        private string _displayName;
        public string DisplayName
        {
            get { return _displayName; }
        }

        public void SetName(string name)
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
        
        public void GetName()
        {

        }
    }
}
