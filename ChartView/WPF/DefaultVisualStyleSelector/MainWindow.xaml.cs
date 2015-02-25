﻿using System;
using System.Collections.Generic;
using System.Windows;

namespace DefaultVisualStyleSelector
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new List<PlotInfo> 
            {
                new PlotInfo { Date = new DateTime(2009, 1, 1), YVal = 100, }, 
                new PlotInfo { Date = new DateTime(2010, 1, 1), YVal = 80, }, 
                new PlotInfo { Date = new DateTime(2011, 1, 1), YVal = 20, }, 
                new PlotInfo { Date = new DateTime(2012, 1, 1), YVal = -40, }, 
                new PlotInfo { Date = new DateTime(2013, 1, 1), YVal = -25, }, 
                new PlotInfo { Date = new DateTime(2014, 1, 1), YVal = 10, }, 
            };
        }
    }
}
