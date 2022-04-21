using MenuWithSubMenu.Models;
using MenuWithSubMenu.ViewModels;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace MenuWithSubMenu.Pages
{
    /// <summary>
    /// Interaction logic for Inbox.xaml
    /// </summary>
    public partial class AddBook : Page
    {
        public AddBook() => InitializeComponent();

        private new void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private async void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                var result = await RestClient.MyPostAsync<ResponseModel, BookDto>("api/books", new BookDto() { Title = tbTitle.Text, Description = tbDescription.Text, ISBN = tbISBN.Text, ImgLink = tbImgLink.Text, PageNumber = int.Parse(tbPageNumber.Text), Price = int.Parse(tbPrice.Text), PublishingYear = int.Parse(tbPublishingYear.Text), PublisherId = int.Parse(tbPublisherId.Text) });

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
            catch (System.Exception)
            {
            }
        }
    }
}
