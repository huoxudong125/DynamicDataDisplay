﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Microsoft.Research.DynamicDataDisplay
{
    public class Footer : ContentControl, IPlotterElement
    {
        public Footer()
        {
            FontSize = 18;
            HorizontalAlignment = HorizontalAlignment.Center;
            Margin = new Thickness(0, 0, 0, 3);
        }

        private Plotter parentPlotter;
        #region IPlotterElement Members

        public void OnPlotterAttached(Plotter plotter)
        {
            parentPlotter = plotter;
            parentPlotter.FooterPanel.Children.Add(this);
        }

        public void OnPlotterDetaching(Plotter plotter)
        {
            parentPlotter = null;
            plotter.FooterPanel.Children.Remove(this);
        }

        public Plotter Plotter
        {
            get { return parentPlotter; }
        }

        #endregion
    }
}
