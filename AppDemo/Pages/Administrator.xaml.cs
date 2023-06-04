using AppDemo.Models;
using AppDemo.Pages.Windows;
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
    /// Interaction logic for Administrator.xaml
    /// </summary>
    public partial class Administrator : Page
    {
        private Staff _currentUser;
        public Administrator(Staff currentUser)
        {
            this._currentUser = currentUser;
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataGridMain.ItemsSource = ConnectDB.modelDB.Orders.ToArray();
        }

        private void addNew_Click(object sender, RoutedEventArgs e)
        {
            AdministratorAdd administratorAdd = new AdministratorAdd();
            administratorAdd.Show();
        }

        private void editSelect_Click(object sender, RoutedEventArgs e)
        {
            Orders currentOrder = dataGridMain.SelectedItem as Orders;
            if (currentOrder != null)
            {
                AdministratorEdit administratorEdit = new AdministratorEdit(currentOrder);
                administratorEdit.Show();
            }
        }

        private void removeSelect_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить пользователя?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                Orders currentOrder = dataGridMain.SelectedItem as Orders;
                if (currentOrder != null)
                {
                    ConnectDB.modelDB.Orders.Remove(currentOrder);
                    ConnectDB.modelDB.SaveChanges();
                    dataGridMain.ItemsSource = ConnectDB.modelDB.Orders.ToList();
                    MessageBox.Show("Пользователи удалены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Вы не выбрали пользователя", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
