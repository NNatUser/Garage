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
    /// Логика взаимодействия для TransitPage.xaml
    /// </summary>
    public partial class TransitPage : Page
    {
        private readonly UserTask ut;
        public TransitPage()
        {
            InitializeComponent();
            DGTransit.ItemsSource = UserTask.OpenDb.Transits.ToList();
        }

        private void DGTransit_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }

        private void BtnAddTransit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnUpdateTransit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
