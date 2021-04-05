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
    /// Interaction logic for LunchMenu.xaml
    /// </summary>
    public partial class LunchMenu : UserControl
    {
        public LunchMenu()
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

        private void DOWN_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new LunchMenu_2());
        }


        //==================================THIS SECTION IS FOR THE ADDING/MINUS OF THE CLASSIC BURGER============================================
        private int burger = 0;
        private int quantity_burger;
        private void Burger_Add_Click(object sender, RoutedEventArgs e)
        {
            quantity_burger = burger;              //Variable to use when adding the prices
            burger = 0;
            App_Count1.Text = burger.ToString();
        }

        private void Add_Burger_Click(object sender, RoutedEventArgs e)
        {
            burger++;
            App_Count1.Text = burger.ToString();
        }

        private void Minus_Burger_Click(object sender, RoutedEventArgs e)
        {
            if (burger < 1)
            {
                App_Count1.Text = burger.ToString();
            }
            else
                burger--;
            App_Count1.Text = burger.ToString();
        }
        //==================================THIS SECTION IS FOR THE ADDING/MINUS OF THE SPICY SHRIMP TACOS============================================
        private int shrimp = 0;
        private int quantity_shrimp;
        private void Shrimp_Add_Click(object sender, RoutedEventArgs e)
        {
            quantity_shrimp = shrimp;              //Variable to use when adding the prices
            shrimp = 0;
            App_Count2.Text = shrimp.ToString();
        }

        private void Add_Shrimp_Click(object sender, RoutedEventArgs e)
        {
            shrimp++;
            App_Count2.Text = shrimp.ToString();
        }

        private void Minus_Shrimp_Click(object sender, RoutedEventArgs e)
        {
            if (shrimp < 1)
            {
                App_Count2.Text = shrimp.ToString();
            }
            else
                shrimp--;
            App_Count2.Text = shrimp.ToString();
        }
    }
}
