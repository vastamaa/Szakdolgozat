using MenuWithSubMenu.Models;
using MenuWithSubMenu.ViewModels;
using System;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace MenuWithSubMenu.Pages
{
    /// <summary>
    /// Interaction logic for Outbox.xaml
    /// </summary>
    public partial class EditBook : Page
    {
        public EditBook() => InitializeComponent();

        private async void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                var result = await RestClient.MyUpdateAsync<ResponseModel, BookDto>($"api/books/{int.Parse(tbBookId.Text)}", new BookDto()
                {
                    Id = int.Parse(tbBookId.Text),
                    Title = tbTitle.Text ?? "",
                    Description = tbDescription.Text ?? "",
                    ISBN = tbISBN.Text ?? "",
                    ImgLink = tbImgLink.Text ?? "",
                    PageNumber = tbPageNumber.Text == "" ? 0 : int.Parse(tbPageNumber.Text),
                    Price = tbPrice.Text == "" ? 0 : int.Parse(tbPrice.Text),
                    PublishingYear = tbPublishingYear.Text == "" ? 0 : int.Parse(tbPublishingYear.Text),
                    PublisherId = tbPublisherId.Text == "" ? 0 : int.Parse(tbPublisherId.Text)
                });


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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private new void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }


}
