using SlippersFactory320AAE.DB;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SlippersFactory320AAE.Pages
{
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void planTb_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Otchet());
        }

        private void workersTb_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Employee());
        }

        private void providersTb_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Providerss());
        }
    }
}
