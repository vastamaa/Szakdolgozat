using BookStore.APIDesktop.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Navigation;

namespace BookStore.APIDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public HttpClient httpClient = new();
        public TokenModel tokenModel;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var payload = new LoginModel()
            {
                UserName = tbUserName.Text,
                Password = tbPassword.Text
            };

            // Serialize our concrete class into a JSON String
            var stringPayload = JsonConvert.SerializeObject(payload);

            // Wrap our JSON inside a StringContent which then can be used by the HttpClient class
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");

            // Do the actual request and await the response
            var httpResponse = await httpClient.PostAsync("https://localhost:5001/api/accounts/admin-login", httpContent);

            // If the response contains content we want to read it!
            if (httpResponse.Content != null)
            {
                if (httpResponse.EnsureSuccessStatusCode() is not null)
                {
                    var responseContent = await httpResponse.Content.ReadAsStringAsync();

                    // From here on you could deserialize the ResponseContent back again to a concrete C# type using Json.Net

                    tokenModel = JsonConvert.DeserializeObject<TokenModel>(responseContent);

                    if (tokenModel.Token is not null)
                    {
                        frame.NavigationService.Navigate(new BooksPage());
                    }
                }
            }
        }
    }
}
