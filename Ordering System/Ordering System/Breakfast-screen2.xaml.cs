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
    public partial class Breakfast-screen2 : UserControl
    {
        public Breakfast-screen2()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
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
        Switcher.Switch(new BreakfastMenu());
    }
        private int burrito = 0;
        private int quantity_burrito;
        private void Add_Burrito_Click(object sender, RoutedEventArgs e)
        {
          
            burrito++;
            App_Count1.Text = burrito.ToString();
        }

        private void Minus_Burrito_Click(object sender, RoutedEventArgs e)
        {
            if (burrito < 1)
            {
                App_Count1.Text = burrito.ToString();
            }
            else
                burrito--;
            App_Count1.Text = burrito.ToString();
        }

        private void Burrito_Add_Click(object sender, RoutedEventArgs e)
        {
            quantity_burrito = burrito;              //Variable to use when adding the prices
            burrito = 0;
            App_Count1.Text = burrito.ToString();
        }
        private int french = 0;
        private int quantity_french;
        private void Add_French_Click(object sender, RoutedEventArgs e)
        {

           

            french++;
            App_Count2.Text = french.ToString();
        }

        private void Minus_French_Click(object sender, RoutedEventArgs e)
        {
            if (french < 1)
            {
                App_Count2.Text = french.ToString();
            }
            else
                french--;
            App_Count2.Text = french.ToString();
        }

        private void French_Add_Click(object sender, RoutedEventArgs e)
        {
            quantity_french = french;              //Variable to use when adding the prices
            french = 0;
            App_Count2.Text = french.ToString();
        }
    }
}
