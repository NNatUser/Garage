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
using System.Windows.Shapes;


namespace Garage.Wind
{
    /// <summary>
    /// Логика взаимодействия для LoginWind.xaml
    /// </summary>
    public partial class LoginWind : Window
    {
        string UserLog;
        string UserPas;
        public LoginWind()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            UserLog = TBLogin.Text;
            UserPas = PBPassword.Password;
            Login(UserLog, UserPas);
        }

        private void Login(string UserLog, string UserPas)
        {
            GarageUser currentUser = UserTask.OpenDb.GarageUsers.FirstOrDefault(u => u.Login == UserLog);
            if (currentUser == null) { MessageBox.Show("Такого пользователя не существует или вы ввели неверные данные!", "Eror", MessageBoxButton.OK, MessageBoxImage.Error); return;};
            if(currentUser.Password != UserPas) { MessageBox.Show("Не верный пароль!", "Error", MessageBoxButton.OK, MessageBoxImage.Error); return; };
            if(currentUser != null)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            };
        }
    }
}
