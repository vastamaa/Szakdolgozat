using BookStore.APIDesktop.Models;
using System;
using System.Windows;

namespace BookStore.APIDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var result = await RestClient.PostAsync("https://localhost:5001/api/accounts/admin-login", new LoginModel
                {
                    UserName = tbUserName.Text,
                    Password = tbPassword.Text
                });

                if (result != null) lblTest.Content = "A bejelentkezés nem sikerült!";
                lblTest.Content = result.Token;
                new AuthenticatedWindow(result).Show();
                Close();
            }
            catch (Exception)
            {
                lblTest.Content = "Hozzáférés megtagadva!";
            }

        }
    }
}
