using MenuWithSubMenu.Models;
using MenuWithSubMenu.ViewModels;
using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace MenuWithSubMenu.Pages
{
    /// <summary>
    /// Interaction logic for EditGenre.xaml
    /// </summary>
    public partial class EditGenre : Page
    {
        public EditGenre()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbGenreId.Text) || string.IsNullOrEmpty(tbGenreName.Text))
                {
                    lblStatus.Foreground = Brushes.Maroon;
                    lblStatus.Content = "You can't submit with empty input field!";
                }
                else
                {
                    var result = await RestClient.MyUpdateAsync<ResponseModel, GenreDto>($"api/genres/{tbGenreId.Text}", new GenreDto() { Id = Convert.ToInt32(tbGenreId.Text), Name = tbGenreName.Text });

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
