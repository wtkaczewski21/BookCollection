using BookCollection.Core.Commands;
using BookCollection.Core.Database;
using BookCollection.Core.Models;
using BookCollection.Core.ViewModels.Base;
using BookCollection.Core.ViewModels.Controls;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BookCollection.Core.ViewModels.Pages
{
    public class BooksPageViewModel : BaseViewModel
    {      
        private readonly IBookService<Book> _bookService;
        private readonly IAuthorService<Author> _authorService;
        private readonly IGenreService<Genre> _genreService;
        public string NewBookTitle { get; set; }
        public ICommand AddNewBookCommand { get; set; }
        public ICommand DeleteSelectedBooksCommand { get; set; }
        public ObservableCollection<BookViewModel> BooksList { get; set; } = new ObservableCollection<BookViewModel>();
        public ObservableCollection<Author> AuthorsList { get; set; } = new ObservableCollection<Author>();
        public ObservableCollection<Genre> GenresList { get; set; } = new ObservableCollection<Genre>();

        public BooksPageViewModel(IBookService<Book> bookService, IAuthorService<Author> authorService, IGenreService<Genre> genreService)
        {
            _bookService = bookService;
            _authorService = authorService;
            _genreService = genreService;
            AddNewBookCommand = new RelayCommand(AddBook);
            DeleteSelectedBooksCommand = new RelayCommand(DeleteSelectedBooks);
        }

        private Author _selectedAuthor;

        public Author SelectedAuthor
        {
            get
            {
                return _selectedAuthor;
            }
            set
            {
                _selectedAuthor = value;
                OnPropertyChanged("SelectedAuthor");
            }
        }

        private Genre _selectedGenre;

        public Genre SelectedGenre
        {
            get
            {
                return _selectedGenre;
            }
            set
            {
                _selectedGenre = value;
                OnPropertyChanged("SelectedGenre");
            }
        }

        public void GetAllBooks()
        {
            foreach (var book in _bookService.GetAllBooks())
            {
                BooksList.Add(new BookViewModel()
                {
                    Id = book.Id,
                    Title = book.Title
                });
            }
        }

        public void GetAllAuthors()
        {
            foreach (var author in _authorService.GetAllAuthors())
            {
                AuthorsList.Add(new Author()
                {
                    AuthorName = author.AuthorName,
                    Id = author.Id
                });
            }
        }

        public void GetAllGenres()
        {
            foreach (var genre in _genreService.GetAllGenres())
            {
                GenresList.Add(new Genre()
                {
                    GenreName = genre.GenreName,
                    Id = genre.Id
                });
            }
        }

        public void AddBook()
        {
            var newBook = new Book()
            {
                Title = NewBookTitle,
                AuthorId = SelectedAuthor.Id,
                GenreId = SelectedGenre.Id
            };
            _bookService.AddBook(newBook);

            var bookViewModel = new BookViewModel()
            {
                Id = newBook.Id,
                Title = NewBookTitle
            };
            BooksList.Add(bookViewModel);

            NewBookTitle = string.Empty;

            OnPropertyChanged(nameof(NewBookTitle));
        }

        public void DeleteSelectedBooks()
        {
            var selectedBooks = BooksList.Where(x => x.IsChecked).ToList();
            foreach (var book in selectedBooks)
            {
                _bookService.DeleteBook(book.Id);
                BooksList.Remove(book);
            }
        }
    }
}
