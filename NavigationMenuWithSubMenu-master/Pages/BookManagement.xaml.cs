using MenuWithSubMenu.ViewModels;
using System.Collections.Generic;
using System.Windows.Controls;

namespace MenuWithSubMenu.Pages
{
    /// <summary>
    /// Interaction logic for Mails.xaml
    /// </summary>
    public partial class BookManagement : Page
    {
        public BookManagement()
        {
            InitializeComponent();
            GetData();
        }

        private async void GetData()
        {
            DataGrid.ItemsSource = await RestClient.MyGetAsync<IEnumerable<BookWithEverythingDto>>("api/books");
        }
    }
}
