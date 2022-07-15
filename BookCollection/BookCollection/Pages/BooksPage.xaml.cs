using BookCollection.Core.ViewModels.Pages;
using System.Windows.Controls;

namespace BookCollection.Pages
{
    /// <summary>
    /// Interaction logic for BooksPage.xaml
    /// </summary>
    public partial class BooksPage : Page
    {
        public BooksPage()
        {
            InitializeComponent();

            DataContext = new BooksPageViewModel();
        }
    }
}
