using System.Windows.Controls;

namespace BookStore.APIDesktop
{
    /// <summary>
    /// Interaction logic for BooksPage.xaml
    /// </summary>
    public partial class BooksPage : Page
    {
        public BooksPage()
        {
            InitializeComponent();
        }
        private void LoadBooks()
        {
            dgBooks.ItemsSource = "";
        }
    }
}