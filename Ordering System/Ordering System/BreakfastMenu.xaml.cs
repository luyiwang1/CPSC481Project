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
    /// Interaction logic for BreakfastMenu.xaml
    /// </summary>
    public partial class BreakfastMenu : UserControl
    {
        public BreakfastMenu()
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

        //==================================THIS SECTION IS FOR THE ADDING/MINUS OF THE OMELETTE============================================
        private int egg = 0;
        private int quantity_egg;
        private void Omelette_Add_Click(object sender, RoutedEventArgs e)
        {
            quantity_egg = egg;          //Variable to use when adding the prices
            egg = 0;
            App_Count1.Text = egg.ToString();
        }
        private void Add_Omelette_Click(object sender, RoutedEventArgs e)
        {
            egg++;
            App_Count1.Text = egg.ToString();
        }

        private void Minus_Omelette_Click(object sender, RoutedEventArgs e)
        {
            if (egg < 1)
            {
                App_Count1.Text = egg.ToString();
            }
            else
                egg--;
            App_Count1.Text = egg.ToString();
        }
        //==================================THIS SECTION IS FOR THE ADDING/MINUS OF THE PANCAKE============================================
        private int pancake = 0;
        private int quantity_pancake;
        private void Pancake_Add_Click(object sender, RoutedEventArgs e)
        {
            quantity_pancake = pancake;          //Variable to use when adding the prices
            pancake = 0;
            App_Count2.Text = pancake.ToString();
        }

        private void Add_Pancake_Click(object sender, RoutedEventArgs e)
        {
            pancake++;
            App_Count2.Text = pancake.ToString();
        }

        private void Minus_Pancake_Click(object sender, RoutedEventArgs e)
        {
            if (pancake < 1)
            {
                App_Count2.Text = pancake.ToString();
            }
            else
                pancake--;
            App_Count2.Text = pancake.ToString();
        }
    }
}
