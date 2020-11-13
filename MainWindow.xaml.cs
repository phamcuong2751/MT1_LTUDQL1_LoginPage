using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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

namespace _18600038
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void Drag_Move(object sender, MouseButtonEventArgs e)
        //{
        //    DragMove();
        //}

        private void Close_Window(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you really want close program!", "Warning", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
                this.Close();

            //MessengeBoxDialog result = new MessengeBoxDialog();
            //result.ShowDialog();
        }

        private void Focus_UserName(object sender, RoutedEventArgs e)
        {
            Text_Focus.Visibility = Visibility.Hidden;
        }

        private void Lost_Focus_Username(object sender, RoutedEventArgs e)
        {
            if(Username.Text.Length == 0)
                Text_Focus.Visibility = Visibility.Visible;
            
        }

        private void Focus_Password(object sender, RoutedEventArgs e)
        {
            Text_Focus_Password.Visibility = Visibility.Hidden;
        }

        private void Lost_Focus_Password(object sender, RoutedEventArgs e)
        {
            if (Password.Password.ToString().Length == 0)
                Text_Focus_Password.Visibility = Visibility.Visible;
        }

        private void GoTo_Setting(object sender, MouseButtonEventArgs e)
        {
            var server = ConfigurationManager.AppSettings["server"];
            var db = ConfigurationManager.AppSettings["database"];

            Debug.WriteLine($"Server: {server}, db: {db}");

            var DialogShow = new SettingWindow(server, db);

            
            if (DialogShow.ShowDialog() == true)
            {
                MessageBox.Show($"Server has been changed to: {DialogShow.Server}, database: {DialogShow.Database}");

                // Luu vao app.config 
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["server"].Value = DialogShow.Server;
                config.AppSettings.Settings["database"].Value = DialogShow.Database;
                config.Save(ConfigurationSaveMode.Minimal);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;

            versionLabel.Content = $"v{version}";
        }
    }
}
