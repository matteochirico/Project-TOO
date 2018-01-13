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

        public enum PanelControlsEnum
        {
            Startscreen,
            Mainscreen
        }

        static UC_Startscreen ucs = new UC_Startscreen();
        static UC_Main ucm = new UC_Main();

        public MainForm()
        {
            InitializeComponent();
            this.Opacity = 0;

            placeHolder = Panel_Placeholder;
            displayNameLabel = Label_DisplayName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer_Start.Start();
            SwitchPanelControls(PanelControlsEnum.Startscreen);
        }

        #region Personalization
        public static void SwitchPanelControls(PanelControlsEnum options)
        {
            switch (options)
            {
                case PanelControlsEnum.Startscreen:
                    placeHolder.Controls.Clear();
                    placeHolder.Controls.Add(ucs);
                    break;
                case PanelControlsEnum.Mainscreen:
                    placeHolder.Controls.Clear();
                    placeHolder.Controls.Add(ucm);
                    break;
            }
        }

        public static void SetDisplayName(string name)
        {
            displayNameLabel.Text = name;
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
    }
}
