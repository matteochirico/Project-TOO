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
        #region Form Stuff
        public UC_Log()
        {
            InitializeComponent();
        }

        private void UC_Log_Load(object sender, EventArgs e)
        {
            cartesianChart1.Series.Add(ProjectController.scPoints[0]);
            cartesianChart1.BackColorTransparent = true;
        }
        #endregion
    }
}
