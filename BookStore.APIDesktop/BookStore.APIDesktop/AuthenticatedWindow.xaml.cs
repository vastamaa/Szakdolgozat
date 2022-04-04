using BookStore.APIDesktop.Models;
using System.Windows;
namespace BookStore.APIDesktop
{
    /// <summary>
    /// Interaction logic for AuthenticatedWindow.xaml
    /// </summary>
    public partial class AuthenticatedWindow : Window
    {
        private static TokenModel _tokenModel;
        public AuthenticatedWindow(TokenModel tokenModel)
        {
            _tokenModel = tokenModel;
            InitializeComponent();
            GetAllBooks();
        }

        private async void GetAllBooks()
        {
            dgBooks.ItemsSource = await RestClient.GetAsync("https://localhost:5001/api/books", _tokenModel.Token);
        }
    }
}
