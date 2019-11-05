﻿using NHM.Wpf.ViewModels.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NHM.Wpf.Views.Devices
{
    /// <summary>
    /// Interaction logic for ComputeDeviceItem.xaml
    /// </summary>
    public partial class ComputeDeviceItem : UserControl
    {
        public ComputeDeviceItem()
        {
            InitializeComponent();
            DataContextChanged += ComputeDeviceItem_DataContextChanged;
            //DataContext = this;
        }

        private void ComputeDeviceItem_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
            if (DataContext is object == false)
            {
                throw new Exception("ComputeDeviceItem DataContext must implement ComputeDeviceItemData");
            }
        }
    }
}