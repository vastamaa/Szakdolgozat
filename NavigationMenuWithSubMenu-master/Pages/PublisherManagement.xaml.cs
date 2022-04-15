using MenuWithSubMenu.ViewModels;
using System.Collections.Generic;
using System.Windows.Controls;

namespace MenuWithSubMenu.Pages
{
    /// <summary>
    /// Interaction logic for PublisherManagement.xaml
    /// </summary>
    public partial class PublisherManagement : Page
    {
        public PublisherManagement()
        {
            InitializeComponent();
            GetData();
        }

        private async void GetData()
        {
            DataGrid.ItemsSource = await RestClient.MyGetAsync<IEnumerable<PublisherDto>>("api/publishers");
        }
    }
}
