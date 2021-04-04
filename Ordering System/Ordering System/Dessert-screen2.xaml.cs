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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Dessert-screen2 : UserControl
    {
        public Dessert-screen2()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        Switcher.Switch(new AppetizerMenu());
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

      

        private void Drinks_Button_Click(object sender, RoutedEventArgs e)
        {
        Switcher.Switch(new DrinksMenu());
    }

        private void Help_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Select the quantity of each item using the plus/minus buttons." + "\n" + "Then press the ADD button to add the items to your order.");

        }

        private void Server_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A staff member will be with you shortly.");
        }

        private void My_Order_Button_Click(object sender, RoutedEventArgs e)
        {
        Switcher.Switch(new MyOrder());
    }

        private void Bill_Button_Click(object sender, RoutedEventArgs e)
        {
        Switcher.Switch(new CheckOut());
    }

        private void UP_Button_Click(object sender, RoutedEventArgs e)
        {
        Switcher.Switch(new DessertMenu());
    }
        private int icecream = 0;
        private int quantity_icecream;

        private void Add_icecream_Click(object sender, RoutedEventArgs e)
        {
            icecream++;
            App_Count1.Text = icecream.ToString();
        }

        private void Minus_icecream_Click(object sender, RoutedEventArgs e)
        {
            if (icecream < 1)
            {
                App_Count1.Text = icecream.ToString();
            }
            else
                icecream--;
            App_Count1.Text = icecream.ToString();
        }

        private void icecream_Add_Click(object sender, RoutedEventArgs e)
        {

            quantity_icecream = icecream;              //Variable to use when adding the prices
            icecream = 0;
            App_Count1.Text = icecream.ToString();
        }
        private int cake = 0;
        private int quantity_cake;

        private void Add_cake_Click(object sender, RoutedEventArgs e)
        {
            cake++;
            App_Count2.Text = cake.ToString();
        }

        private void Minus_cake_Click(object sender, RoutedEventArgs e)
        {
            if (cake < 1)
            {
                App_Count2.Text = cake.ToString();
            }
            else
                cake--;
            App_Count2.Text = cake.ToString();
        }

        private void cake_Add_Click(object sender, RoutedEventArgs e)
        {

            quantity_cake = cake;              //Variable to use when adding the prices
            cake = 0;
            App_Count2.Text = cake.ToString();
        }
    }
}
