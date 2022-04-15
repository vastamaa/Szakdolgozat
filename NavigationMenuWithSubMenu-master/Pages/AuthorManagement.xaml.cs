using MenuWithSubMenu.ViewModels;
using System.Collections.Generic;
using System.Windows.Controls;

namespace MenuWithSubMenu.Pages
{
    /// <summary>
    /// Interaction logic for AuthorManagement.xaml
    /// </summary>
    public partial class AuthorManagement : Page
    {
        public AuthorManagement()
        {
            InitializeComponent();
            GetData();
        }

        private async void GetData()
        {
            DataGrid.ItemsSource = await RestClient.MyGetAsync<IEnumerable<AuthorDto>>("api/authors");
        }
    }
}
