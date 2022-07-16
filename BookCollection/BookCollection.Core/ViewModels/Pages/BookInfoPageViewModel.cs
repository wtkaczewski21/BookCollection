using BookCollection.Core.Database;
using BookCollection.Core.Models;
using BookCollection.Core.ViewModels.Base;
using System.Collections.ObjectModel;

namespace BookCollection.Core.ViewModels.Pages
{
    public class BookInfoPageViewModel : BaseViewModel
    {
        public string BookInfoTitle { get; set; }
        public string BookInfoAuthorName { get; set; }
        public string BookInfoGenreName { get; set; }
        public string BookInfoRating { get; set; }

        private readonly IBookService<Book> _bookService;
        private readonly IAuthorService<Author> _authorService;
        private readonly IGenreService<Genre> _genreService;
        private readonly IRatingService<BookRating> _ratingService;

        public BookInfoPageViewModel(IBookService<Book> bookService, IAuthorService<Author> authorService, IGenreService<Genre> genreService, IRatingService<BookRating> ratingService)
        {
            _bookService = bookService;
            _authorService = authorService;
            _genreService = genreService;
            _ratingService = ratingService;
        }

        public void GetBookInfo(int bookId)
        {
            var bookInfo = _bookService.GetBookById(bookId);
            var authors = _authorService.GetAllAuthors();
            var genres = _genreService.GetAllGenres();
            var ratings = _ratingService.GetAllRatings();
            var bookAuthorId = bookInfo.AuthorId;
            var bookGenreId = bookInfo.GenreId;
            var bookRatingId = bookInfo.BookRatingId;
            BookInfoTitle = bookInfo.Title;
            BookInfoAuthorName = authors.FirstOrDefault(x => x.Id == bookAuthorId)?.AuthorName;
            BookInfoGenreName = genres.FirstOrDefault(x => x.Id == bookGenreId)?.GenreName;
            BookInfoRating = ratings.FirstOrDefault(x => x.Id == bookRatingId)?.Rating;
        }
    }
}
