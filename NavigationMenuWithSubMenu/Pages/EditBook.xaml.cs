using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;

namespace MenuWithSubMenu.Pages
{
    /// <summary>
    /// Interaction logic for Outbox.xaml
    /// </summary>
    public partial class EditBook : Page
    {
        public EditBook() => InitializeComponent();

        private new void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }

    
}
