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
    public partial class UC_Main : UserControl
    {
        public UC_Main()
        {
            InitializeComponent();
        }

        #region Color Handling
        private void Panel_Start_MouseEnter(object sender, EventArgs e)
        {
            Label_Start.ForeColor = Color.FromArgb(192, 192, 192);
            Picture_Start.Image = Properties.Resources.Start_Test__Silver_;
        }

        private void Panel_Start_MouseLeave(object sender, EventArgs e)
        {
            Label_Start.ForeColor = Color.FromArgb(255, 255, 255);
            Picture_Start.Image = Properties.Resources.Start_Test__White_;
        }

        private void Panel_Log_MouseEnter(object sender, EventArgs e)
        {
            Label_Log.ForeColor = Color.FromArgb(192, 192, 192);
            Picture_Log.Image = Properties.Resources.History__Silver_;
        }

        private void Panel_Log_MouseLeave(object sender, EventArgs e)
        {
            Label_Log.ForeColor = Color.FromArgb(255, 255, 255);
            Picture_Log.Image = Properties.Resources.History__White_;
        }
        #endregion

        private void Log_Clicked(object sender, EventArgs e)
        {
            MainForm.mf.Picture_GoBack.Visible = true;
            MainForm.SwitchPanelUC(MainForm.UserControl.Log);
        }
    }
}
