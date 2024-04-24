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

namespace CinemaPr.Properties
{

    public partial class JSONConv : Window
    {
            CinemasTableAdapter cinema = new CinemasTableAdapter();
        public JSONConv()
        {
           
            InitializeComponent();

            CinemasDgr.ItemsSource = cinema.GetData();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Model> forImport = LabaConverter.Deserialize0bject<List<Model>>();
            foreach (var item in forImport)
            {
                cinema.InsertQuery(item.NameCinema, Convert.ToInt32(item.Capacity));
            }

            CinemasDgr.ItemsSource = null;
            CinemasDgr.ItemsSource = cinema.GetData();
        }
    }
}
