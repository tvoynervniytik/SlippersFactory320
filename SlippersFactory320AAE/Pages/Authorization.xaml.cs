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
using SlippersFactory320AAE.DB;

namespace SlippersFactory320AAE.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public static List<Administrator> administrators { get; set; }
        public Authorization()
        {
            InitializeComponent();
        }

        private void Window1_Click(object sender, RoutedEventArgs e)
        {
            string login = loginTb.Text.Trim();
            string password = passwordTb.Password.Trim();

            administrators = new List<Administrator>(DbConection.slippersFactory.Administrator.ToList());
            Administrator currentUser = administrators.FirstOrDefault(i => i.Login == login && i.Password == password);
            if (currentUser != null)
                NavigationService.Navigate(new HomePage());
            else
                MessageBox.Show("All's wrong");
        }
    }
}
