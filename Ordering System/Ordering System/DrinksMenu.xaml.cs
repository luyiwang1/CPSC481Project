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
    /// Interaction logic for DrinksMenu.xaml
    /// </summary>
    public partial class DrinksMenu : UserControl
    {
        public DrinksMenu()
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

        private void Dessert_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new DessertMenu());
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
            Switcher.Switch(new DrinksMenu_2());
        }
       

        //==================================THIS SECTION IS FOR THE ADDING/MINUS OF THE COKE============================================
        private int coke = 0;
        private int quantity_coke;
        private void Coke_Add_Click(object sender, RoutedEventArgs e)
        {
            quantity_coke = coke;              //Variable to use when adding the prices
            coke = 0;
            App_Count1.Text = coke.ToString();
        }

        private void Add_Coke_Click(object sender, RoutedEventArgs e)
        {
            coke++;
            App_Count1.Text = coke.ToString();
        }

        private void Minus_Coke_Click(object sender, RoutedEventArgs e)
        {
            if (coke < 1)
            {
                App_Count1.Text = coke.ToString();
            }
            else
                coke--;
            App_Count1.Text = coke.ToString();
        }
        //==================================THIS SECTION IS FOR THE ADDING/MINUS OF THE SPRITE============================================
        private int sprite = 0;
        private int quantity_sprite;
        private void Sprite_Add_Click(object sender, RoutedEventArgs e)
        {
            quantity_sprite = sprite;              //Variable to use when adding the prices
            sprite = 0;
            App_Count2.Text = sprite.ToString();
        }

        private void Add_Sprite_Click(object sender, RoutedEventArgs e)
        {
            sprite++;
            App_Count2.Text = sprite.ToString();
        }

        private void Minus_Sprite_Click(object sender, RoutedEventArgs e)
        {
            if (sprite < 1)
            {
                App_Count2.Text = sprite.ToString();
            }
            else
                sprite--;
            App_Count2.Text = sprite.ToString();
        }

        private void GoBack_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new WelcomeScreen());
        }
    }
}
