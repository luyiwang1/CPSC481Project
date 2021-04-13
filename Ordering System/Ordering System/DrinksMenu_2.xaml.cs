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
    /// Interaction logic for DrinksMenu_2.xaml
    /// </summary>
    public partial class DrinksMenu_2 : UserControl
    {
        public DrinksMenu_2()
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

        private void Dessert_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new DessertMenu());
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
            Switcher.Switch(new Order_B3());
        }

        private void UP_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new DrinksMenu());
        }

        private int beer = 0;
        private int quantity_beer;
        private void Add_Beer_Click(object sender, RoutedEventArgs e)
        {
            beer++;
            App_Count1.Text = beer.ToString();
        }

        private void Minus_Beer_Click(object sender, RoutedEventArgs e)
        {
            if (beer < 1)
            {
                App_Count1.Text = beer.ToString();
            }
            else
                beer--;
            App_Count1.Text = beer.ToString();
        }

        private void Beer_Add_Click(object sender, RoutedEventArgs e)
        {
            quantity_beer = beer;              //Variable to use when adding the prices
            beer = 0;
            App_Count1.Text = beer.ToString();
        }

        private int wine = 0;
        private int quantity_wine;
        private void Add_Wine_Click(object sender, RoutedEventArgs e)
        {
            wine++;
            App_Count2.Text = wine.ToString();
        }

        private void Minus_Wine_Click(object sender, RoutedEventArgs e)
        {

            if (wine < 1)
            {
                App_Count2.Text = wine.ToString();
            }
            else
                wine--;
            App_Count2.Text = wine.ToString();
        }

        private void Wine_Add_Click(object sender, RoutedEventArgs e)
        {
            quantity_wine = wine;              //Variable to use when adding the prices
            wine = 0;
            App_Count2.Text = wine.ToString();
        }

        private void Drinks_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GoBack_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new WelcomeScreen());
        }

        private void Appetizer_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
