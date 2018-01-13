using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_TOO
{
    public static class ProjectController
    {
        static Form1 form1 = new Form1();
       
        #region UserControls
        public static void ChangeUserControl(Panel panel, UserControl userControl)
        {
            foreach (Control control in form1.Controls.OfType<Control>())
            {
                if (control.Name == "Panel_Placeholder")
                {
                    panel.Controls.Remove(control);
                }
            }

            foreach (Control control in form1.Controls.OfType<Control>())
            {
                if (control.Name == "Panel_Placeholder")
                {
                    panel.Controls.Add(userControl);
                }
            }
        }
        #endregion
    }
}
