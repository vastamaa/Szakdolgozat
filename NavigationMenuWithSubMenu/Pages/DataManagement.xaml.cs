using BookStore.API.DTOs;
using System.Collections.Generic;
using System.Windows.Controls;

namespace MenuWithSubMenu.Pages
{
    /// <summary>
    /// Interaction logic for DataManagement.xaml
    /// </summary>
    public partial class DataManagement : Page
    {
        public DataManagement()
        {
            InitializeComponent();
            GetData();
        }

        private async void GetData() => DataGrid.ItemsSource = await RestClient.MyGetAsync<IEnumerable<Book_AuthorDto>>("api/books_authors");
    }
}
