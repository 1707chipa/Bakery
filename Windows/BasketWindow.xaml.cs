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
using System.Windows.Shapes;
using Bakery_Sanin_Cheprasov.ClassHelper;
using Bakery_Sanin_Cheprasov.DB;
using Bakery_Sanin_Cheprasov.Windows;
using static Bakery_Sanin_Cheprasov.ClassHelper.EFClass;

namespace Bakery_Sanin_Cheprasov
{
    /// <summary>
    /// Логика взаимодействия для BasketWindow.xaml
    /// </summary>
    public partial class BasketWindow : Window
    {
 
        public BasketWindow()
        {
            InitializeComponent();
            LvProduct.ItemsSource = CartProductClass.products;
            double a = 0;
            string a1;
            foreach (Product product in CartProductClass.products)
            {
                a += Convert.ToDouble(product.Cost.ToString());
                Tballcost.Text = a.ToString();
            }
            ClassHelper.FridaySale fridaySale = new FridaySale();
            Tballcost.Text = fridaySale.ApplyDiscount(Tballcost.Text);

        }

        private void BtnDelProduct_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if(button == null)
            {
                return;
            }
            var product = (Product)button.DataContext;
            if(product != null)
            {
                CartProductClass.products.Remove(product);
                LvProduct.ItemsSource = CartProductClass.products;
                LvProduct.Items.Refresh();
                
            }
            product.Quantity = product.Quantity + 1;
            Context.SaveChanges();
            LvProduct.Items.Refresh();
        }

        private void BtnBuyProduct_Click(object sender, RoutedEventArgs e)
        {
            var x = UserAccauntClass.user;
            MessageBox.Show("Ок", "Спасибо за покупку!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            foreach (Product pr in CartProductClass.products)
            {

            }
            CartProductClass.products.Clear();
            ListOfProductsWindow listOfProductsWindow = new ListOfProductsWindow();
            listOfProductsWindow.Show();
            this.Close();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            ListOfProductsWindow listOfProductsWindow = new ListOfProductsWindow();
            listOfProductsWindow.Show();
            this.Close();
        }
    }
}
