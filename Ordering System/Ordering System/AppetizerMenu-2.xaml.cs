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
    /// Interaction logic for AppetizerMenu_2.xaml
    /// </summary>
    public partial class AppetizerMenu_2 : UserControl
    {
        public AppetizerMenu_2()
        {
            InitializeComponent();
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
        private int buffalowings = 0;
        private int quantity_buffalowings;

        //This function stores the number of quantity selected and puts them into an int save_nachos to use for later (Quantity*Price)
        private void Buffalowings_Add_Click(object sender, RoutedEventArgs e)
        {

            quantity_buffalowings = buffalowings;              //Variable to use when adding the prices
            buffalowings = 0;
            App_Count1.Text = buffalowings.ToString();
        }

        private void Add_Buffaloswings_Click(object sender, RoutedEventArgs e)
        {
            buffalowings++;
            App_Count1.Text = buffalowings.ToString();
        }

        private void Minus_Buffalowings_Click(object sender, RoutedEventArgs e)
        {
            if (buffalowings < 1)
            {
                App_Count1.Text = buffalowings.ToString();
            }
            else
                buffalowings--;
            App_Count1.Text = buffalowings.ToString();
        }

        private int onionrings = 0;
        private int quantity_onionrings;
        private void Onionrings_Add_Click(object sender, RoutedEventArgs e)
        {
            quantity_onionrings = onionrings;              //Variable to use when adding the prices
            onionrings = 0;
            App_Count2.Text = onionrings.ToString();
        }
        private void Add_Onionrings_Click(object sender, RoutedEventArgs e)
        {
            onionrings++;
            App_Count2.Text = onionrings.ToString();
        }

        private void Minus_Onionrings_Click(object sender, RoutedEventArgs e)
        {
            if (onionrings < 1)
            {
                App_Count2.Text = onionrings.ToString();
            }
            else
                onionrings--;
            App_Count2.Text = onionrings.ToString();
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
            Switcher.Switch(new AppetizerMenu());
        }

        private void Appetizer_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
