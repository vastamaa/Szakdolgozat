using MenuWithSubMenu.ViewModels;
using System.Collections.Generic;
using System.Windows.Controls;

namespace MenuWithSubMenu.Pages
{
    /// <summary>
    /// Interaction logic for LanguageManagement.xaml
    /// </summary>
    public partial class LanguageManagement : Page
    {
        public LanguageManagement()
        {
            InitializeComponent();
            GetData();
        }
        private async void GetData()
        => DataGrid.ItemsSource = await RestClient.MyGetAsync<IEnumerable<LanguageDto>>("api/languages");
    }
}
