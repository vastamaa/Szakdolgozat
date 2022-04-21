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
    /// Interaction logic for EditAuthor.xaml
    /// </summary>
    public partial class EditAuthor : Page
    {
        public EditAuthor() => InitializeComponent();

        private async void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbAuthorId.Text) || string.IsNullOrEmpty(tbAuthorName.Text))
                {
                    lblStatus.Foreground = Brushes.Maroon;
                    lblStatus.Content = "You can't submit with empty input field!";
                }
                else
                {
                    var result = await RestClient.MyUpdateAsync<ResponseModel, AuthorDto>($"api/authors/{tbAuthorId.Text}", new AuthorDto() { Id = Convert.ToInt32(tbAuthorId.Text), Name = tbAuthorName.Text });

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
            catch (Exception)
            {
            }
        }

        private new void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
