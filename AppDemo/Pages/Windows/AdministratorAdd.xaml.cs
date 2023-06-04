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
using System.Windows.Shapes;

namespace AppDemo.Pages.Windows
{
    /// <summary>
    /// Interaction logic for AdministratorAdd.xaml
    /// </summary>
    public partial class AdministratorAdd : Window
    {
        public AdministratorAdd()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comboBoxIDstatus.ItemsSource = ConnectDB.modelDB.StatusOrders.ToList();
        }
        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            string dateNow = $"{DateTime.Now.Date.Day}.{DateTime.Now.Date.Month}.{DateTime.Now.Date.Year}";
            DateTime timeNow = DateTime.Now;

            StatusOrders curStatusOrders = comboBoxIDstatus.SelectedItem as StatusOrders;

            Orders order = new Orders();
            order.codeOrder = $"{textBoxIDclient.Text}/{dateNow}";
            order.dateCreate = timeNow;
            order.timeCreate = TimeSpan.Parse(timeNow.ToLongTimeString());
            order.IDclient = int.Parse(textBoxIDclient.Text);
            order.service = textBoxService.Text;
            order.IDstatus = curStatusOrders.ID;
            if (datePickerDateClose.Text != "")
                order.dateClose = DateTime.Parse(datePickerDateClose.Text);
            else
                order.dateClose = null;
            order.timeRent = int.Parse(textBoxTimeRent.Text);
            ConnectDB.modelDB.Orders.Add(order);
            ConnectDB.modelDB.SaveChanges();
            MessageBox.Show("Пользователь добавлен!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}
