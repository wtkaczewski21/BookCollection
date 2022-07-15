using BookCollection.Core.Database;
using BookCollection.Core.Models;
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
            IBookService<Book> bookService = new BookService<Book>(new DesignTimeDbContextFactory());
            IAuthorService<Author> authorService = new AuthorService<Author>(new DesignTimeDbContextFactory());
            IGenreService<Genre> genreService = new GenreService<Genre>(new DesignTimeDbContextFactory());

            var viewModel = new BooksPageViewModel(bookService, authorService, genreService);
            viewModel.GetAllBooks();
            viewModel.GetAllAuthors();
            viewModel.GetAllGenres();
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}
