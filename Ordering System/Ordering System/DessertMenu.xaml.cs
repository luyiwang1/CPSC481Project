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
    /// Interaction logic for DessertMenu.xaml
    /// </summary>
    public partial class DessertMenu : UserControl
    {
        public DessertMenu()
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

        private void Appetizer_Button_Click(object sender, RoutedEventArgs e)
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

        private void My_Order_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MyOrder());
        }

        private void Bill_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new CheckOut());
        }

        private void DOWN_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new DessertMenu_2());
        }

        //==================================THIS SECTION IS FOR THE ADDING/MINUS OF THE CHEESECAKE============================================
        private int cake = 0;
        private int quantity_cake;
        private void Cake_Add_Click(object sender, RoutedEventArgs e)
        {
            quantity_cake = cake;              //Variable to use when adding the prices
            cake = 0;
            App_Count1.Text = cake.ToString();
        }

        private void Add_Cake_Click(object sender, RoutedEventArgs e)
        {
            cake++;
            App_Count1.Text = cake.ToString();
        }

        private void Minus_Cake_Click(object sender, RoutedEventArgs e)
        {
            if (cake < 1)
            {
                App_Count1.Text = cake.ToString();
            }
            else
                cake--;
            App_Count1.Text = cake.ToString();
        }
        //==================================THIS SECTION IS FOR THE ADDING/MINUS OF THE MAPLE APPLE PIE============================================
        private int pie = 0;
        private int quantity_pie;
        private void Pie_Add_Click(object sender, RoutedEventArgs e)
        {
            quantity_pie = pie;              //Variable to use when adding the prices
            pie = 0;
            App_Count2.Text = pie.ToString();
        }

        private void Add_Pie_Click(object sender, RoutedEventArgs e)
        {
            pie++;
            App_Count2.Text = pie.ToString();
        }

        private void Minus_Pie_Click(object sender, RoutedEventArgs e)
        {
            if (pie < 1)
            {
                App_Count2.Text = pie.ToString();
            }
            else
                pie--;
            App_Count2.Text = pie.ToString();
        }

    }
}
