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
    public partial class UC_Log : UserControl
    {
        public UC_Log()
        {
            InitializeComponent();
        }

        private void UC_Log_Load(object sender, EventArgs e)
        {
            cartesianChart1.Series.Add(ProjectController.scPoints[0]);
            cartesianChart1.Series.Add(ProjectController.scTime[0]);
            cartesianChart1.BackColorTransparent = true;
            ProjectController.scPoints[0].Values.Add(0);
            ProjectController.scPoints[0].Values.Add(5);
            ProjectController.scPoints[0].Values.Add(2);
            ProjectController.scTime[0].Values.Add(2);
            ProjectController.scTime[0].Values.Add(8);
            ProjectController.scTime[0].Values.Add(5);
        }
    }
}
