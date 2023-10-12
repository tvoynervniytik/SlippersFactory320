using SlippersFactory320AAE.DB;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Claims;
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
    /// Логика взаимодействия для Employee.xaml
    /// </summary>
    public partial class Employee : Page
    {
        public static List<Worker> employees { get; set; }
        public static List<Machine> machines { get; set; }
        public Employee()
        {
            InitializeComponent();
            employees = new List<Worker>(DbConection.slippersFactory.Worker.ToList());
            machines = new List<Machine>(DbConection.slippersFactory.Machine.ToList());
            this.DataContext = this;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var dcvd = SurnameTb.Text + " " + NameTb.Text + " " + PatronymicTb.Text
                + " ";

            
                Worker employee = new Worker();

                employee.Surname = SurnameTb.Text.Trim();
                employee.Name = NameTb.Text.Trim();
                employee.Patronymic = PatronymicTb.Text.Trim();
                //employee.Id_Machine = ClassesCb.

                DbConection.slippersFactory.Worker.Add(employee);
                DbConection.slippersFactory.SaveChanges();

                ClientsLv.ItemsSource = new List<Worker>(DbConection.slippersFactory.Worker.ToList());
        }
        private void ClientsLvv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Worker worker =
                ClientsLv.SelectedItem as Worker;
        }
        private void ClassesCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Machine machine = ClassesCb.SelectedItem as Machine;
            ClassesCb.ItemsSource = new List<Worker>
                (DbConection.slippersFactory.Worker.
                Where(l => l.Id_Machine == machine.Id).ToList());
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            ClientsLv.ItemsSource = new List<Worker>(DbConection.slippersFactory.Worker.
                Where(i => i.Surname.StartsWith(SearchTb.Text)).ToList());
        }
        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            ClientsLv.ItemsSource = new List<Worker>(DbConection.slippersFactory.Worker.
                Where(i => i.Surname.StartsWith(SearchTb.Text)).ToList());
        }

    }
}
