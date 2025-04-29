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

namespace Garage
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnMain_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.Content != null) { MainFrame.Content = null; }
        }

        private void BtnTransit_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.Content != null) { MainFrame.Content = null; }
            MainFrame.Navigate(new Uri("../Pages/TransitPage.xaml", UriKind.Relative));

        }

        private void BtnCatalog_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.Content != null) { MainFrame.Content = null; }
            MainFrame.Navigate(new Uri("../Pages/Catalog.xaml", UriKind.Relative));
        }
    }
}
