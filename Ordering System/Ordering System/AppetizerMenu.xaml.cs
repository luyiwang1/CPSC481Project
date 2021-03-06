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
    /// Interaction logic for AppetizerMenu.xaml
    /// </summary>
    
    public partial class AppetizerMenu : UserControl
    {
        public AppetizerMenu()
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

        private void My_Order_Button_Click(object sender, RoutedEventArgs e)
        {
          
            if(quantity_nachos > 1)
            {
                Switcher.Switch(new Order_C1());
            }else
                Switcher.Switch(new Order_A1());

        }

        private void Bill_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Order_A4());
        }


        private void DOWN_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AppetizerMenu_2());
        }

        //==================================THIS SECTION IS FOR THE ADDING/MINUS OF THE NACHOS============================================
        int nachos = 0;
        private int quantity_nachos;

        //This function stores the number of quantity selected and puts them into an int save_nachos to use for later (Quantity*Price)
       

        private void Nachos_Add_Click(object sender, RoutedEventArgs e)
        {
            quantity_nachos = nachos;              //Variable to use when adding the prices
            nachos = 0;
            App_Count1.Text = nachos.ToString();
        }

        private void Add_Nachos_Click(object sender, RoutedEventArgs e)
        {
            nachos++;
            App_Count1.Text = nachos.ToString();
        }

        private void Minus_Nachos_Click(object sender, RoutedEventArgs e)
        {
            if (nachos < 1)
            {
                App_Count1.Text = nachos.ToString();

            }
            else
                nachos--;
            App_Count1.Text = nachos.ToString();
        }
        //==================================THIS SECTION IS FOR THE ADDING/MINUS OF THE STRAWBERRY============================================
        private int berry = 0;
        private int quantity_berry;
        //This function stores the number of quantity selected and puts them into an int save_nachos to use for later(Quantity* Price)
        
        private void Add_Berry_Click(object sender, RoutedEventArgs e)
        {
            berry++;
            App_Count2.Text = berry.ToString();
        }

        private void Minus_Berry_Click(object sender, RoutedEventArgs e)
        {
            if (berry < 1)
            {
                App_Count2.Text = berry.ToString();
            }
            else
                berry--;
            App_Count2.Text = berry.ToString();
        }

        private void Berry_Add_Click(object sender, RoutedEventArgs e)
        {
            quantity_berry = berry;          //Variable to use when adding the prices
            berry = 0;
            App_Count2.Text = berry.ToString();

           }

        private void GoBack_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new WelcomeScreen());    
        }
    }
    
}
