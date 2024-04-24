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

namespace CinemaPr
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        private readonly MoviesTableAdapter movieAdapter = new MoviesTableAdapter();

        public Add()
        {
            InitializeComponent();
            MovieDgr.ItemsSource = movieAdapter.GetData();
        }

        private void AddMovieButton_Click(object sender, RoutedEventArgs e)
        {
            
            CinemaPrDataSet.MoviesRow newMovieRow = movieAdapter.GetData().NewRow() as CinemaPrDataSet.MoviesRow;

            
            newMovieRow.Title = "Название фильма";
            newMovieRow.Director = "Режиссер";
            newMovieRow.Genre = "Жанр";
            newMovieRow.Rating = 0.0;

          
            movieAdapter.GetData().Rows.Add(newMovieRow);

        
            movieAdapter.Update(movieAdapter.GetData());
        }

        private void TitleTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DirectorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void GenreTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}