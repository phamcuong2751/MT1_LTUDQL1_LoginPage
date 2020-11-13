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

namespace _18600038
{
    /// <summary>
    /// Interaction logic for SettingWindow.xaml
    /// </summary>
    public partial class SettingWindow : Window
    {
        private string _server;
        private string _database;

        public string Server = "";
        public string Database = "";


        public SettingWindow(string server, string database)
        {
            InitializeComponent();
            _server = server;
            _database = database;

        }

        private void Close_Window(object sender, RoutedEventArgs e)
        {
            //this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            box_Server.Text = $"{_server}";
            box_Database.Text = $"{_database}";
        }

        private void OK_Button(object sender, RoutedEventArgs e)
        {
                Server = box_Server.Text;
                Database = box_Database.Text;

                DialogResult = true;
        }
    }
}
