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
    /// Логика взаимодействия для Providerss.xaml
    /// </summary>
    public partial class Providerss : Page
    {
        public static List<Provider> providers { get; set; }
        public static List<TypeProvider> typeProviders { get; set; }
        public Providerss()
        {
            InitializeComponent();
            providers = new List<Provider>(DbConection.slippersFactory.Provider.ToList());
            typeProviders = new List<TypeProvider>(DbConection.slippersFactory.TypeProvider.ToList());
            this.DataContext = this;
        }
    }
}
