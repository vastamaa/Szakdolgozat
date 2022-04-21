using MenuWithSubMenu.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace MenuWithSubMenu.Pages
{
    /// <summary>
    /// Interaction logic for DeleteData.xaml
    /// </summary>
    public partial class DeleteData : Page
    {
        public DeleteData() => InitializeComponent();

        private async void Button_Click(object sender, RoutedEventArgs e)
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
                    var result = await RestClient.MyDeleteAsync<ResponseModel>($"api/books_authors/{tb.Text}");

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
