using BookCollection.Core.Models;
using BookCollection.Core.ViewModels.Base;

namespace BookCollection.Core.ViewModels.Controls
{
    public class BookViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public bool IsChecked { get; set; }
        public int BookRatingId { get; set; }
        public BookRating BookRatingShow { get; set; }
    }
}
