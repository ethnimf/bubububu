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
   
    public partial class UpDateWindow : Window
    {
        BookingTableAdapter booking = new BookingTableAdapter();
        
        public UpDateWindow()
        {
            InitializeComponent();
            BookinDgr.ItemsSource = booking.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            booking.InsertQuery(DateBooking.Text, Convert.ToInt32(Screening_ID.Text), Convert.ToInt32(Ticket_ID.Text));
            BookinDgr.ItemsSource = booking.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object id = (BookinDgr.SelectedItem as DataRowView).Row[2];
            booking.UpdateQuery(DateBooking.Text, Convert.ToInt32(Screening_ID.Text), Convert.ToInt32(Ticket_ID.Text), Convert.ToInt32(ID_Booking.Text));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (BookinDgr.SelectedItem as DataRowView).Row[2];
            booking.DeleteQuery(Convert.ToInt32(id));

        }

        private void BookinDgr_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (BookinDgr.SelectedItems.Count > 0)
            {
                DataRowView rowView = BookinDgr.SelectedItems[0] as DataRowView;

                if (rowView != null)
                {
                    string valueColumn1 = rowView["DateBooking"].ToString();
                    string valueColumn2 =rowView["Screening_ID"].ToString();
                    string valueColumn3 = rowView["Ticket_ID"].ToString();
                    string valueColumn4 = rowView["ID_Booking"].ToString();

                    DateBooking.Text = valueColumn1;
                    Screening_ID.Text = valueColumn2;
                    Ticket_ID.Text = valueColumn3;
                    ID_Booking.Text = valueColumn4;


                }
            }
        }
    }
}
