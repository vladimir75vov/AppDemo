using AppDemo.Models;
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

namespace AppDemo.Pages
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Staff currentUser = ConnectDB.modelDB.Staff.FirstOrDefault(x => textBoxLogin.Text == x.login && passwordBoxPassword.Password == x.password);
                if (currentUser != null)
                {
                    redirectPage(currentUser.IDrole, currentUser);
                    MessageBox.Show($"Добро пожаловать {currentUser.SFMname}, {currentUser.RolesStaff.title}", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show($"Ошибка, такого пользователя нету", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка {ex.Message}", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void redirectPage(int roleID, Staff currentUser)
        {
            switch (roleID)
            {
                case 1://Администратор                                     
                    NavigationService.Navigate(new Administrator(currentUser));
                    break;
                case 2://Старший смены                                     
                    NavigationService.Navigate(new ShiftSupervisor(currentUser));
                    break;
                case 3://Продавец                                          
                    NavigationService.Navigate(new Seller(currentUser)); 
                    break;
                default:
                    MessageBox.Show($"Ошибка, нету роли", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
            }
        }
    }
}
