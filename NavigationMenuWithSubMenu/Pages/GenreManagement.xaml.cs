using MenuWithSubMenu.ViewModels;
using System.Collections.Generic;
using System.Windows.Controls;

namespace MenuWithSubMenu.Pages
{
    /// <summary>
    /// Interaction logic for GenreManagement.xaml
    /// </summary>
    public partial class GenreManagement : Page
    {
        public GenreManagement()
        {
            InitializeComponent();
            GetData();
        }
        private async void GetData() => DataGrid.ItemsSource = await RestClient.MyGetAsync<IEnumerable<GenreDto>>("api/genres");
    }
}
