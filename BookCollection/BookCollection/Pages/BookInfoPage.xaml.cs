using BookCollection.Core.Database;
using BookCollection.Core.Models;
using BookCollection.Core.ViewModels.Pages;
using System.Windows.Controls;

namespace BookCollection.Pages
{
    /// <summary>
    /// Interaction logic for BookInfoPage.xaml
    /// </summary>
    public partial class BookInfoPage : Page
    {
        public BookInfoPage(int bookId)
        {
            IBookService<Book> bookService = new BookService<Book>(new DesignTimeDbContextFactory());
            IAuthorService<Author> authorService = new AuthorService<Author>(new DesignTimeDbContextFactory());
            IGenreService<Genre> genreService = new GenreService<Genre>(new DesignTimeDbContextFactory());
            IRatingService<BookRating> ratingService = new RatingService<BookRating>(new DesignTimeDbContextFactory());

            var viewModel = new BookInfoPageViewModel(bookService, authorService, genreService, ratingService);
            viewModel.GetBookInfo(bookId);
            DataContext = viewModel;

            InitializeComponent();
        }
    }
}
