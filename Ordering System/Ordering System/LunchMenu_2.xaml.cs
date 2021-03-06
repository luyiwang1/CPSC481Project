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
    /// Interaction logic for LunchMenu_2.xaml
    /// </summary>
    public partial class LunchMenu_2 : UserControl
    {
        public LunchMenu_2()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AppetizerMenu());
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
            Switcher.Switch(new LunchMenu());
        }

        private int filet = 0;
        private int quantity_filet;

        private void Add_FiletMignon_Click(object sender, RoutedEventArgs e)
        {
            filet++;
            App_Count1.Text = filet.ToString();
        }

        private void Minus_FiletMignon_Click(object sender, RoutedEventArgs e)
        {

            if (filet < 1)
            {
                App_Count1.Text = filet.ToString();
            }
            else
                filet--;
            App_Count1.Text = filet.ToString();
        }

        private void FiletMignon_Add_Click(object sender, RoutedEventArgs e)
        {
            quantity_filet = filet;              //Variable to use when adding the prices
            filet = 0;
            App_Count1.Text = filet.ToString();
        }

        private int alfredo = 0;
        private int quantity_alfredo;
        private void Add_Alfredo_Click(object sender, RoutedEventArgs e)
        {
            alfredo++;
            App_Count2.Text = alfredo.ToString();
        }

        private void Minus_Alfredo_Click(object sender, RoutedEventArgs e)
        {

            if (alfredo < 1)
            {
                App_Count2.Text = alfredo.ToString();
            }
            else
                alfredo--;
            App_Count2.Text = alfredo.ToString();
        }

        private void Alfredo_Add_Click(object sender, RoutedEventArgs e)
        {
            quantity_alfredo = alfredo;              //Variable to use when adding the prices
            alfredo = 0;
            App_Count2.Text = alfredo.ToString();
        }

        private void Lunch_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GoBack_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new WelcomeScreen());
        }
    }
}
