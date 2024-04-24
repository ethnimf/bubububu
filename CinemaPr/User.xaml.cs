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
using CinemaPr.CinemaPrDataSetTableAdapters;
using CinemaPr.Properties;
using Newtonsoft.Json.Linq;

namespace CinemaPr
{

    public partial class User : Window
    {
        BookingTableAdapter booking = new BookingTableAdapter();
        CinemasTableAdapter cinemas = new CinemasTableAdapter();    
        ScheduleTableAdapter schedule = new ScheduleTableAdapter(); 
        public User()
        {
            InitializeComponent();
        }

        private void Broni_show_Click(object sender, RoutedEventArgs e)
        {
            BookingDgr.ItemsSource = booking.GetData();
        }

        private void Cinema_show_Click(object sender, RoutedEventArgs e)
        {
            CinemaDgr.ItemsSource = cinemas.GetData();
            JSONConv jSON = new JSONConv();
           
        }

        private void Scheuld_show_Click(object sender, RoutedEventArgs e)
        {
            ScheduleDgr.ItemsSource = schedule.GetData();
        }

        private void Setting_show_Click(object sender, RoutedEventArgs e)
        {
            UpDateWindow update = new UpDateWindow();
            update.ShowDialog();  
        }

      
    }
}
