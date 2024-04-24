using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using CinemaPr.CinemaPrDataSetTableAdapters;

namespace CinemaPr
{
    public partial class MainWindow : Window
    {
        DataaTableAdapter adapter = new DataaTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var allogins = adapter.GetData().Rows;

            for (int i = 0; i < allogins.Count; i++)
            {
                if (allogins[i][1].ToString() == LoginBox.Text &&
                allogins[i][2].ToString() == PasswordBox.Password)
                {
                    int roleId = (int)allogins[i][0];
                    switch (roleId)
                    {
                        case 1:
                            User userWindow = new User();
                            userWindow.ShowDialog();
                            this.Close();
                            break;
                        case 2:
                            Kassir cashierWindow = new Kassir();
                            cashierWindow.ShowDialog();
                            this.Close();
                            break;
                    }
                    return;
                }
            }      
        }
    }
}