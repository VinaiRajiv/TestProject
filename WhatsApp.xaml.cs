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

namespace Whatsap_UI
{
    /// <summary>
    /// Interaction logic for WhatsApp.xaml
    /// </summary>
    public partial class WhatsApp : Window
    {
        public WhatsApp()
        {
            InitializeComponent();
        }

        private void btnwhts_Click(object sender, RoutedEventArgs e)
        {
            WhatsApp_Home whatsApp_home = new WhatsApp_Home();
            this.Content = whatsApp_home;
        }
    }
}
