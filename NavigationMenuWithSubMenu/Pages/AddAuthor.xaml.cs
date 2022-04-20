using MenuWithSubMenu.Models;
using MenuWithSubMenu.ViewModels;
using System.Windows.Controls;
using System.Windows.Media;

namespace MenuWithSubMenu.Pages
{
    /// <summary>
    /// Interaction logic for AddAuthor.xaml
    /// </summary>
    public partial class AddAuthor : Page
    {
        public AddAuthor() => InitializeComponent();

        private async void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    lblStatus.Foreground = Brushes.Maroon;
                    lblStatus.Content = "You can't submit an empty input field!";
                }
                else
                {
                    var result = await RestClient.MyPostAsync<ResponseModel, AuthorDto>("api/authors", new AuthorDto() { Name = tb.Text });

                    if (result.Status.Contains("Error!"))
                    {
                        lblStatus.Foreground = Brushes.Maroon;
                        lblStatus.Content = $"{result.Status}\n{result.Message}";
                    }
                    else
                    {
                        lblStatus.Foreground = Brushes.Lime;
                        lblStatus.Content = $"{result.Status}\n{result.Message}";
                    }
                }
            }
            catch (System.Exception)
            {
            }
        }
    }
}
