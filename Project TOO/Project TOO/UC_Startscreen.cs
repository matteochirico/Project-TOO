using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_TOO
{
    public partial class UC_Startscreen : UserControl
    {
        public UC_Startscreen()
        {
            InitializeComponent();
        }
        
        private void Textbox_Click(object sender, EventArgs e)
        {
            Textbox.Focus();
        }

        private void Procced_Click(object sender, EventArgs e)
        {
            ProjectController controller = new ProjectController();

            if (!string.IsNullOrWhiteSpace(Textbox.Text))
            {
                controller.SetName(Textbox.Text);
            }

            MainForm.SwitchPanelControls(MainForm.PanelControlsEnum.Mainscreen);
        }
    }
}
