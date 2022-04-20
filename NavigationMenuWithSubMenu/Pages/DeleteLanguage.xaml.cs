using MenuWithSubMenu.Models;
using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace MenuWithSubMenu.Pages
{
    /// <summary>
    /// Interaction logic for DeleteLanguage.xaml
    /// </summary>
    public partial class DeleteLanguage : Page
    {
        public DeleteLanguage() => InitializeComponent();

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
                    var result = await RestClient.MyDeleteAsync<ResponseModel>($"api/languages/{tb.Text}");

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
    }
}
