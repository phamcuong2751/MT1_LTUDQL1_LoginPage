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
    /// Interaction logic for MessengeBoxDialog.xaml
    /// </summary>
    public partial class MessengeBoxDialog : Window
    {
        public MessengeBoxDialog()
        {
            InitializeComponent();
        }

        private void Button_Yes(object sender, MouseButtonEventArgs e)
        {
            MainWindow MainDialog = new MainWindow();
            this.Close();
            MainDialog.Close();
        }

        private void Button_No(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
