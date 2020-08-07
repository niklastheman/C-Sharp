using GUI.Home;
using Logic.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI.Login
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private const string _errorMsg = "Inloggningen misslyckades";

        private LoginService _loginService;
        public LoginPage()
        {
            InitializeComponent();

            _loginService = new LoginService();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = this.tbUsernam.Text;
            string password = this.pbPassword.Password;

            bool successful = _loginService.Login(username, password);

            if (successful)
            {

                HomePage homePage = new HomePage();

                this.NavigationService.Navigate(homePage);
            }
            else
            {

                MessageBox.Show(_errorMsg);
                this.tbUsernam.Clear();
                this.pbPassword.Clear();
            }
        }
    }
}
