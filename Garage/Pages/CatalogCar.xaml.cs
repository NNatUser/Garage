using Garage.Model;
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
    /// Логика взаимодействия для CatalogCar.xaml
    /// </summary>
    public partial class CatalogCar : Page
    {
        public CatalogCar()
        {
            InitializeComponent();
            DGCar.ItemsSource = UserTask.OpenDb.Cars.ToList();
        }

        private void DGCar_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }
    }
}
