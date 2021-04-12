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
    /// Interaction logic for Order_A4.xaml
    /// </summary>
    public partial class Order_A4 : UserControl
    {
        public Order_A4()
        {
            InitializeComponent();
        }

        private void Cash_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please wait as a staff member will arrive with your bill shortly.");
        }

        private void Credit_Debit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please wait as a staff member will arrive with your bill shortly.");
        }
    }
}
