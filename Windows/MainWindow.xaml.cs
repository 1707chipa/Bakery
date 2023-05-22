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
using Bakery_Sanin_Cheprasov.ClassHelper;
using Bakery_Sanin_Cheprasov.DB;
using Bakery_Sanin_Cheprasov.Windows;
using static Bakery_Sanin_Cheprasov.ClassHelper.EFClass;

namespace Bakery_Sanin_Cheprasov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NameSpace.Text = ClassHelper.UserAccauntClass.user.Login.ToString();
        }

        private void PrList_Click(object sender, RoutedEventArgs e)
        {

                ListOfProductsWindow listOfProductsWindow = new ListOfProductsWindow();
                listOfProductsWindow.Show();
                this.Close();


        }

        private void Employers_Click(object sender, RoutedEventArgs e)
        {
            if (ClassHelper.UserAccauntClass.user.IdRole == 1)
            {
                MessageBox.Show("Нет доступа", "Вы не сотрудник", MessageBoxButton.YesNo, MessageBoxImage.Error);
                return;
            }
            else
            {
                if (1 != 1)
                {
                    SellerListWindow sellerListWindow = new SellerListWindow();
                    sellerListWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Функция в разработке");
                }

            }
        }

        private void Otchett_Click(object sender, RoutedEventArgs e)
        {
            if (ClassHelper.UserAccauntClass.user.IdRole == 3)
            {
                ReportsWindow reportsWindow = new ReportsWindow();
                reportsWindow.Show();
                this.Close();
            }
        }
    }
}
