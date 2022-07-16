using BookCollection.Core.Database;
using BookCollection.Core.Models;
using BookCollection.Core.ViewModels.Pages;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace BookCollection.Pages
{
    /// <summary>
    /// Interaction logic for BooksPage.xaml
    /// </summary>
    public partial class BooksPage : Page
    {
        public BooksPage()
        {         
            IBookService<Book> bookService = new BookService<Book>(new DesignTimeDbContextFactory());
            IAuthorService<Author> authorService = new AuthorService<Author>(new DesignTimeDbContextFactory());
            IGenreService<Genre> genreService = new GenreService<Genre>(new DesignTimeDbContextFactory());
            IRatingService<BookRating> ratingService = new RatingService<BookRating>(new DesignTimeDbContextFactory());

            var viewModel = new BooksPageViewModel(bookService, authorService, genreService, ratingService);
            viewModel.GetAllBooks();
            viewModel.GetAllAuthors();
            viewModel.GetAllGenres();
            viewModel.GetAllRatings();
            DataContext = viewModel;
            InitializeComponent();
        }

        private void BookInfoButton(object sender, RoutedEventArgs e)
        {
            var btn = ((Button)sender).Tag;
            BookInfoPage bookInfoPage = new BookInfoPage((int)btn);
            NavigationService navigationService = this.NavigationService;
            navigationService.Navigate(bookInfoPage);
        }
    }
}
