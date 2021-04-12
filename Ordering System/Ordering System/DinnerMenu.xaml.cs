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
    /// Interaction logic for DinnerMenu.xaml
    /// </summary>
    public partial class DinnerMenu : UserControl
    {
        public DinnerMenu()
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
            Switcher.Switch(new Order_D1());
        }

        private void Bill_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new CheckOut());
        }

        private void DOWN_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new DinnerMenu_2());
        }


        //==================================THIS SECTION IS FOR THE ADDING/MINUS OF THE NOODLES============================================
        private int noodles = 0;
        private int quantity_noodles;
        private void Noodles_Add_Click(object sender, RoutedEventArgs e)
        {
            quantity_noodles = noodles;              //Variable to use when adding the prices
            noodles = 0;
            App_Count1.Text = noodles.ToString();
        }

        private void Add_Noodles_Click(object sender, RoutedEventArgs e)
        {
            noodles++;
            App_Count1.Text = noodles.ToString();
        }

        private void Minus_Noodles_Click(object sender, RoutedEventArgs e)
        {
            if (noodles < 1)
            {
                App_Count1.Text = noodles.ToString();
            }
            else
                noodles--;
            App_Count1.Text = noodles.ToString();
        }
        //==================================THIS SECTION IS FOR THE ADDING/MINUS OF THE FISH AND CHIPS============================================
        private int fc = 0;
        private int quantity_fc;
        private void FC_Add_Click(object sender, RoutedEventArgs e)
        {
            quantity_fc = fc;              //Variable to use when adding the prices
            fc = 0;
            App_Count2.Text = fc.ToString();
        }

        private void Add_FC_Click(object sender, RoutedEventArgs e)
        {
            fc++;
            App_Count2.Text = fc.ToString();
        }

        private void Minus_FC_Click(object sender, RoutedEventArgs e)
        {
            if (fc < 1)
            {
                App_Count2.Text = fc.ToString();
            }
            else
                fc--;
            App_Count2.Text = fc.ToString();
        }

        private void GoBack_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new WelcomeScreen());
        }
    }
}
