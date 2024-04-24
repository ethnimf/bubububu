using System;
using System.Collections.Generic;
using System.Data;
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
using CinemaPr.CinemaPrDataSetTableAdapters;

namespace CinemaPr
{
    /// <summary>
    /// Логика взаимодействия для Kassir.xaml
    /// </summary>
    public partial class Kassir : Window
    {
        SalesTableAdapter sales = new SalesTableAdapter();
        ScreeningTableAdapter screening = new ScreeningTableAdapter();
        TicketsTableAdapter tickets = new TicketsTableAdapter();

        public Kassir()
        {
            InitializeComponent();
            TicketsDgr.ItemsSource = tickets.GetData();
            TicketsCbx.ItemsSource = tickets.GetData();
        }

        private void Sales_show_Click_1(object sender, RoutedEventArgs e)
        {
            SalesDgr.ItemsSource = sales.GetData();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Screeen_show_Click_1(object sender, RoutedEventArgs e)
        {
            ScreeningDgr.ItemsSource = screening.GetData();
           
        }

        private void Ticket_show_Click_1(object sender, RoutedEventArgs e)
        {
            TicketsDgr.ItemsSource = tickets.GetData();
            TicketsDgr.ItemsSource = tickets.toSearch(SearchTxt.Text);
            TicketsCbx.DisplayMemberPath = "Status";
        }

        private void TicketsCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(TicketsCbx.SelectedItem != null)
            {
                var id = (int)(TicketsCbx.SelectedItem as DataRowView).Row[0];
                TicketsDgr.ItemsSource = tickets.GetDataBy(id);
            }
        }
    }
}
