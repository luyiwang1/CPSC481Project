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
    /// Interaction logic for CheckOut.xaml
    /// </summary>
    public partial class CheckOut : UserControl
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void Return_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AppetizerMenu());
        }

        private void Help_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Select your method of payment by choosing cash or credit/debit." + "\n" + "If you wish to add more items to your order, press Return to Menu.");
        }

        private void Cash_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please wait as a staff member will arrive with your bill shortly.");
        }

        private void CreditDebit_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please wait as a staff member will arrive with your bill shortly.");
        }
    }
}
