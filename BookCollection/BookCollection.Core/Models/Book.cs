namespace BookCollection.Core.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public int BookRatingId { get; set; }
        public virtual BookRating BookRating { get; set; }
    }
}
