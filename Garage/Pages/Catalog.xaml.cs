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

namespace Garage.Pages
{
    /// <summary>
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Page
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void BtnOpenCatalogCar_Click(object sender, RoutedEventArgs e)
        {
            if (FrameCatalog.Content != null) { FrameCatalog.Content = null; }
            FrameCatalog.Navigate(new Uri("Pages/CatalogCar.xaml", UriKind.Relative));
        }

        private void BtnOpenCatalogDriver_Click(object sender, RoutedEventArgs e)
        {
            if (FrameCatalog.Content != null) { FrameCatalog.Content = null; }
            FrameCatalog.Navigate(new Uri("Pages/CatalogDriver.xaml", UriKind.Relative));
        }

        private void BtnOpenCatalogFuel_Click(object sender, RoutedEventArgs e)
        {
            if (FrameCatalog.Content != null) { FrameCatalog.Content = null; }
            FrameCatalog.Navigate(new Uri("Pages/CatalogFuel.xaml", UriKind.Relative));
        }
    }
}
