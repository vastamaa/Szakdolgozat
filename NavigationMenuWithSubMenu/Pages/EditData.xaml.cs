using BookStore.API.DTOs;
using MenuWithSubMenu.Models;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MenuWithSubMenu.Pages
{
    /// <summary>
    /// Interaction logic for EditData.xaml
    /// </summary>
    public partial class EditData : Page
    {
        public EditData() => InitializeComponent();

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbAuthorId.Text) || string.IsNullOrEmpty(tbBookId.Text) || string.IsNullOrEmpty(tbGenreId.Text) || string.IsNullOrEmpty(tbLanguageId.Text) || string.IsNullOrEmpty(tbRowId.Text))
                {
                    lblStatus.Foreground = Brushes.Maroon;
                    lblStatus.Content = "You can't submit with empty input field!";
                }
                else
                {
                    var result = await RestClient.MyUpdateAsync<ResponseModel, Book_AuthorDto>($"api/books_authors/{tbRowId.Text}", new Book_AuthorDto() { Id = int.Parse(tbRowId.Text), AuthorId = int.Parse(tbAuthorId.Text), BookId = int.Parse(tbBookId.Text), GenreId = int.Parse(tbGenreId.Text), LanguageId = int.Parse(tbLanguageId.Text) });

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
