﻿using System;
using System.Collections.Generic;
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

namespace Ordering_System
{
    /// <summary>
    /// Interaction logic for Order_C4.xaml
    /// </summary>
    public partial class Order_C4 : UserControl
    {
        public Order_C4()
        {
            InitializeComponent();
        }

        private void Return_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AppetizerMenu());
        }
    }
}
