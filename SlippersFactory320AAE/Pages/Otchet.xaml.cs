using SlippersFactory320AAE.DB;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
    /// Логика взаимодействия для Otchet.xaml
    /// </summary>
    public partial class Otchet : Page
    {
        public static List<Plann> plans { get; set; }
        public Otchet()
        {
            InitializeComponent();
            plans = new List<Plann>(DbConection.slippersFactory.Plann.ToList());
            this.DataContext = this;

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var dcvd = DatePlann.SelectedDate + " " + NormOTb + " " + NormZTb  + " " + ColOtTb + " " + ColZTb;

            Plann plan = new Plann();   
            plan.Date = DatePlann.SelectedDate;
            plan.NormO = int.Parse(NormOTb.Text);
            plan.NormZ = int.Parse(NormZTb.Text);
            plan.ColOSlippers = int.Parse(ColOtTb.Text);
            plan.ColZSlippers = int.Parse(ColZTb.Text);

            DbConection.slippersFactory.Plann.Add(plan);
            DbConection.slippersFactory.SaveChanges();

            ClientsLv.ItemsSource = new List<Plann>(DbConection.slippersFactory.Plann.ToList());

        }
        private void ClientsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Plann plan =
                ClientsLv.SelectedItem as Plann;
        }
    }
}
