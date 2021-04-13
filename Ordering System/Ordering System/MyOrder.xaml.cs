using System;
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
    /// Interaction logic for MyOrder.xaml
    /// </summary>
    public partial class MyOrder : UserControl
    {
        public MyOrder()
        {
            InitializeComponent();
        }

        private void Return_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AppetizerMenu());
        }

        private void Help_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Increase or decrease the quantity of items in your order using the plus/minus buttons." + "\n" + "Press the Place Order button if you are satisfied with your order." + "\n" + "Press the Order Take Out button if you wish to order as takeout." + "\n" + "If you wish to add more items to your order, press Return to Menu.");
        }

        private void Place_Order_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your order has been placed and your food will arrive shortly. Thank you!");
           
        }

        private void TakeOut_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
