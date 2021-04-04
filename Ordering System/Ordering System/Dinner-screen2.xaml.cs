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
    public partial class Dinner-screen2 : UserControl
    {
        public Dinner-screen2()
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


        private void Dessert_Button_Click(object sender, RoutedEventArgs e)
        {
        Switcher.Switch(new DessertMenu());
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
        Switcher.Switch(new DinnerMenu());
    }

        private int steak = 0;
        private int quantity_steak;
        private void Add_Steak_Click(object sender, RoutedEventArgs e)
        {
            steak++;
            App_Count1.Text = steak.ToString();
        }

        private void Minus_Steak_Click(object sender, RoutedEventArgs e)
        {
            if (steak < 1)
            {
                App_Count1.Text = steak.ToString();
            }
            else
                steak--;
            App_Count1.Text = steak.ToString();
        }

        private void Steak_Add_Click(object sender, RoutedEventArgs e)
        {
            quantity_steak = steak;              //Variable to use when adding the prices
            steak = 0;
            App_Count1.Text = steak.ToString();
        }

        private int lobster = 0;
        private int quantity_lobster;
        private void Add_Lobster_Click(object sender, RoutedEventArgs e)
        {
            lobster++;
            App_Count2.Text = lobster.ToString();
        }

        private void Minus_Lobster_Click(object sender, RoutedEventArgs e)
        {
            if (lobster < 1)
            {
                App_Count2.Text = lobster.ToString();
            }
            else
                lobster--;
            App_Count2.Text = lobster.ToString();
        }

        private void Lobster_Add_Click(object sender, RoutedEventArgs e)
        {
            quantity_lobster = lobster;              //Variable to use when adding the prices
            lobster = 0;
            App_Count2.Text = lobster.ToString();
        }
    }
}
