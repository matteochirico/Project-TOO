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
    public partial class Form1 : Form
    {
        public static UC_Startscreen UCS = new UC_Startscreen();

        public Form1()
        {
            InitializeComponent();
            this.Opacity = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer_Start.Start();
            ProjectController.ChangeUserControl(Panel_Placeholder, UCS);
        }

        #region FadeIn & FadeOut
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
    }
}
