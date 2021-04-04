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
    /// Interaction logic for AppetizerMenu.xaml
    /// </summary>
    public partial class AppetizerMenu : UserControl
    {
        public AppetizerMenu()
        {
            InitializeComponent();
        }

        private void Help_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Select the quantity of each item using the plus/minus buttons." + "\n" + "Then press the ADD button to add the items to your order.");
        }

        private void Server_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A staff member will be with you shortly.");
        }

        private void Breakfast_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new BreakfastMenu());
        }

        private void Lunch_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new LunchMenu());
        }

        private void Dinner_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new DinnerMenu());
        }

        private void Dessert_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new DessertMenu());
        }

        private void Drinks_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new DrinksMenu());
        }

        private void My_Order_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MyOrder());
        }

        private void Bill_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new CheckOut());
        }

        private int x = 0;

        private void Add_Nachos_Click(object sender, RoutedEventArgs e)
        {
            x++;
            App_Count1.Text = x.ToString();
        }

        private void Minus_Nachos_Click(object sender, RoutedEventArgs e)
        {
            if (x < 1)
            {
                App_Count1.Text = x.ToString();
            } else
            x--;
            App_Count1.Text = x.ToString();
        }
        private void DOWN_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Appetizers-screen2());
        }
    }
}
