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
    /// Interaction logic for Order_D5.xaml
    /// </summary>
    public partial class Order_D5 : UserControl
    {
        public Order_D5()
        {
            InitializeComponent();
        }

        private void Place_Order_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your order has been placed and your food will arrive shortly. Thank you!");
            Switcher.Switch(new Order_D6());
        }
    }
}
