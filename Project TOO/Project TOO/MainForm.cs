using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_TOO
{
    public partial class MainForm : Form
    {
        static Panel placeHolder;
        static Label displayNameLabel;
        public static MainForm mf;

        static UC_Startscreen ucs = new UC_Startscreen();
        static UC_Main ucm = new UC_Main();
        static UC_Log ucl = new UC_Log();

        public enum UserControl
        {
            Startscreen,
            Mainscreen,
            Log
        }

        public MainForm()
        {
            InitializeComponent();
            this.Opacity = 0;
            mf = this;

            placeHolder = Panel_Placeholder;
            displayNameLabel = Label_DisplayName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer_Start.Start();
            SwitchPanelUC(UserControl.Startscreen);
        }

        #region Personalization & Mouse Events
        public static void SwitchPanelUC(UserControl userControl)
        {
            switch (userControl)
            {
                case UserControl.Startscreen:
                    placeHolder.Controls.Clear();
                    placeHolder.Controls.Add(ucs);
                    break;
                case UserControl.Mainscreen:
                    placeHolder.Controls.Clear();
                    placeHolder.Controls.Add(ucm);
                    break;
                case UserControl.Log:
                    placeHolder.Controls.Clear();
                    placeHolder.Controls.Add(ucl);
                    break;
            }
        }

        public static void SetDisplayName(string name)
        {
            displayNameLabel.Text = name;
        }
        
        private void Picture_Exit_MouseEnter(object sender, EventArgs e)
        {
            Picture_Exit.Image = Properties.Resources.Exit_Application__Silver_;
        }

        private void Picture_Exit_MouseLeave(object sender, EventArgs e)
        {
            Picture_Exit.Image = Properties.Resources.Exit_Application__White_;
        }

        private void Picture_Minimize_MouseEnter(object sender, EventArgs e)
        {
            Picture_Minimize.Image = Properties.Resources.Minimize_Application__Silver_;
        }

        private void Picture_Minimize_MouseLeave(object sender, EventArgs e)
        {
            Picture_Minimize.Image = Properties.Resources.Minimize_Application__White_;
        }

        private void Picture_GoHome_MouseEnter(object sender, EventArgs e)
        {
            Picture_GoHome.Image = Properties.Resources.Go_Home__Silver_;
        }

        private void Picture_GoHome_MouseLeave(object sender, EventArgs e)
        {
            Picture_GoHome.Image = Properties.Resources.Go_Home__White_;
        }

        #region Fade in & Out
        private void Picture_Exit_Click(object sender, EventArgs e)
        {
            Timer_Exit.Start();
        }

        private void Picture_Minimize_Click(object sender, EventArgs e)
        {
            Timer_MinimizeOut.Start();
        }

        private void Timer_Exit_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.1;

            if (Opacity == 0)
            {
                Timer_Exit.Stop();
                Application.Exit();
            }
        }

        private void Timer_Start_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;

            if (Opacity == 1)
            {
                Timer_Start.Stop();
            }
        }

        private void Timer_MinimizeOut_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.1;

            if (Opacity == 0)
            {
                Timer_MinimizeOut.Stop();
                WindowState = FormWindowState.Minimized;
                Timer_MinimizeIn.Start();
            }
        }

        private void Timer_MinimizeIn_Tick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Opacity += 0.1;

                if (Opacity == 1)
                {
                    Timer_MinimizeIn.Stop();
                }
            }
        }
        #endregion
        #endregion

        private void Picture_GoBackClicked(object sender, EventArgs e)
        {
            GoBack();
        }

        public void GoBack()
        {
            if (placeHolder.Controls.Contains(ucl))
            {
                SwitchPanelUC(UserControl.Mainscreen);
                Picture_GoHome.Visible = false;
            }
        }
    }
}
