using MenuWithSubMenu.Models;
using System;
using System.Windows;

namespace MenuWithSubMenu
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var result = await RestClient.MyPostAsync<TokenModel, LoginModel>("api/accounts/admin-login", new LoginModel
                {
                    UserName = tbUsername.Text,
                    Password = tbPassword.Password
                }); ;

                Globals.Token = result.Token;

                if (result != null)
                    new MainWindow().Show();
                Close();
            }
            catch (Exception)
            {
            }
        }
    }
}
