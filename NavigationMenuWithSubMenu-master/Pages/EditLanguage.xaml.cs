using MenuWithSubMenu.Models;
using MenuWithSubMenu.ViewModels;
using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace MenuWithSubMenu.Pages
{
    /// <summary>
    /// Interaction logic for EditLanguage.xaml
    /// </summary>
    public partial class EditLanguage : Page
    {
        public EditLanguage()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbLanguageId.Text) || string.IsNullOrEmpty(tbLanguageName.Text))
                {
                    lblStatus.Foreground = Brushes.Maroon;
                    lblStatus.Content = "You can't submit with empty input field!";
                }
                else
                {
                    var result = await RestClient.MyUpdateAsync<ResponseModel, LanguageDto>($"api/languages/{tbLanguageId.Text}", new LanguageDto() { Id = Convert.ToInt32(tbLanguageId.Text), Name = tbLanguageName.Text });

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
