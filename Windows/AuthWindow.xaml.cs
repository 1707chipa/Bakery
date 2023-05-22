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
using Bakery_Sanin_Cheprasov.Windows;
using Bakery_Sanin_Cheprasov.ClassHelper;
using Bakery_Sanin_Cheprasov.DB;
using static Bakery_Sanin_Cheprasov.ClassHelper.EFClass;

namespace Bakery_Sanin_Cheprasov.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void NewRegistation_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            this.Close();
        }
        public static int acc;
        private void Authbutton_Click(object sender, RoutedEventArgs e)
        {
            var userAuth = Context.UserAccount.ToList()
                .Where(i => i.Login == Tblogin.Text && 
                i.Password == PbPassword.Text)
                .FirstOrDefault();
                ClassHelper.UserAccauntClass.user = userAuth;
            UserAccauntClass.user1 = userAuth;
            if (userAuth.IdRole == 1)
            {
                acc = 1;
            }
            else if (userAuth.IdRole == 2)
            {
                acc = 2;
            }
            else
            {
                acc = 3;
            }
            if(userAuth != null) 
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("пользователь не найден");
            }
        }
    }
}
