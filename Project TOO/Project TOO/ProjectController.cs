﻿using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Project_TOO
{
    public static class ProjectController
    {
        #region LiveChart Objects & Variables
        public static SeriesCollection scPoints = new SeriesCollection
        {
            new LineSeries
            {
                Title = "Poeng",
                DataLabels = true,
                Values = new ChartValues<int>(),
                //PointGeometry = null,
                LineSmoothness = 1,
                Fill = new SolidColorBrush
                {
                    Color = System.Windows.Media.Color.FromRgb(37, 65, 84),
                    Opacity = 0.1
                }
            }
        };

        public static SeriesCollection scTime = new SeriesCollection
        {
            new LineSeries
            {
                Title = "Tid",
                DataLabels = true,
                Values = new ChartValues<int>(),
                //PointGeometry = null,
                LineSmoothness = 1,
                Fill = new SolidColorBrush
                {
                    Color = System.Windows.Media.Color.FromRgb(37, 65, 84),
                    Opacity = 0.1
                }
            }
        };
        #endregion

        #region Get Name & Set Name Functions
        private static string _displayName;
        public static string DisplayName
        {
            get { return _displayName; }
        }

        public static void SetDisplayName(string name)
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
        #endregion
    }
}
