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

    public partial class AdministratorEdit : Window
    {
        private Orders _order = null;
        public AdministratorEdit(Orders order)
        {
            this._order = order;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comboBoxIDstatus.ItemsSource = ConnectDB.modelDB.StatusOrders.ToList();

            textBoxCodeOrder.Text = _order.codeOrder;

            datePickerDateCreate.Text = _order.dateCreate.ToString();
            datePickerDateCreate.DisplayDate = _order.dateCreate;

            textBoxTimeCreate.Text = _order.timeCreate.ToString();
            textBoxIDclient.Text = _order.IDclient.ToString();
            textBoxService.Text = _order.service;

            comboBoxIDstatus.SelectedItem = _order.StatusOrders.title;
            comboBoxIDstatus.Text = _order.StatusOrders.title;

            if (_order.dateClose != null)
            {
                datePickerDateClose.Text = _order.dateClose.ToString();
                datePickerDateClose.DisplayDate = (DateTime)_order.dateClose;
            }

            textBoxTimeRent.Text = _order.timeRent.ToString();
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            StatusOrders curStatusOrders = comboBoxIDstatus.SelectedItem as StatusOrders;

            Orders order = new Orders();

            order.ID = _order.ID;
            order.codeOrder = textBoxCodeOrder.Text;
            order.dateCreate = DateTime.Parse(datePickerDateCreate.Text);
            order.timeCreate = TimeSpan.Parse(textBoxTimeCreate.Text);
            order.IDclient = int.Parse(textBoxIDclient.Text);
            order.service = textBoxService.Text;
            order.IDstatus = curStatusOrders.ID;
            if (datePickerDateClose.Text != "")
                order.dateClose = DateTime.Parse(datePickerDateClose.Text);
            else
                order.dateClose = null;
            order.timeRent = int.Parse(textBoxTimeRent.Text);
        }
    }
}
