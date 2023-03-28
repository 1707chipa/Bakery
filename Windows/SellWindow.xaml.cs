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
    /// Логика взаимодействия для SellWindow.xaml
    /// </summary>
    public partial class SellWindow : Window
    {
        public SellWindow()
        {
            InitializeComponent();
            LvProduct.ItemsSource = CartProductClass.products;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            BasketWindow basketWindow = new BasketWindow();
            basketWindow.Show();
            this.Close();
        }

        private void BtnBuyProduct_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ок","Спасибо за покупку!",MessageBoxButton.OK,MessageBoxImage.Exclamation);
            CartProductClass.products.Clear();
            ListOfProductsWindow listOfProductsWindow = new ListOfProductsWindow();
            listOfProductsWindow.Show();
            this.Close();
        }
    }
}
