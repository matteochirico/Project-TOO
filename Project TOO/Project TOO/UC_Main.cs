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
        #region Form Stuff
        public UC_Main()
        {
            InitializeComponent();
        }
        #endregion

        #region Color Handling & Click Events
        private void Panel_Start_MouseEnter(object sender, EventArgs e)
        {
            Label_Start.ForeColor = Color.FromArgb(64, 64, 65);
            Picture_Start.Image = Properties.Resources.Start_Test__DarkGray_;
        }

        private void Panel_Start_MouseLeave(object sender, EventArgs e)
        {
            Label_Start.ForeColor = Color.FromArgb(74, 74, 75);
            Picture_Start.Image = Properties.Resources.Start_Test__DimGray_;
        }

        private void Panel_Log_MouseEnter(object sender, EventArgs e)
        {
            Label_Log.ForeColor = Color.FromArgb(64, 64, 65);
            Picture_Log.Image = Properties.Resources.History__DarkGray_;
        }

        private void Panel_Log_MouseLeave(object sender, EventArgs e)
        {
            Label_Log.ForeColor = Color.FromArgb(74, 74, 75);
            Picture_Log.Image = Properties.Resources.History__DimGray_;
        }

        private void Log_Clicked(object sender, EventArgs e)
        {
            MainForm.mf.Picture_GoHome.Visible = true;
            MainForm.SwitchPanelUC(MainForm.UserControl.Log);
        }

        private void Panel_Log_Click(object sender, EventArgs e)
        {
            MainForm.mf.Picture_GoHome.Visible = true;
            MainForm.SwitchPanelUC(MainForm.UserControl.Log);
        }

        private void StartTest_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
