using BookCollection.Pages;
using System.Windows;

namespace BookCollection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _defaultView.NavigationService.Navigate(new BooksPage());
        }
    }
}
