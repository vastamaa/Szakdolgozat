using MenuWithSubMenu.Models;
using MenuWithSubMenu.ViewModels;
using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace MenuWithSubMenu.Pages
{
    /// <summary>
    /// Interaction logic for EditPublisher.xaml
    /// </summary>
    public partial class EditPublisher : Page
    {
        public EditPublisher()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbPublisherId.Text) || string.IsNullOrEmpty(tbPublisherName.Text))
                {
                    lblStatus.Foreground = Brushes.Maroon;
                    lblStatus.Content = "You can't submit with empty input field!";
                }
                else
                {
                    var result = await RestClient.MyUpdateAsync<ResponseModel, PublisherDto>($"api/publishers/{tbPublisherId.Text}", new PublisherDto() { Id = Convert.ToInt32(tbPublisherId.Text), Name = tbPublisherName.Text });

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
