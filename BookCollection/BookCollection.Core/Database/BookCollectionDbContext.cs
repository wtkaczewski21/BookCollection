using BookCollection.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace BookCollection.Core.Database
{
    public class BookCollectionDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<BookRating> BookRatings { get; set; }
        public BookCollectionDbContext(DbContextOptions<BookCollectionDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 1,
                Title = "Harry Potter and the Half-Blood Prince",
                AuthorId = 1,
                GenreId = 2,
                BookRatingId = 5,
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 2,
                Title = "I, Robot",
                AuthorId = 3,
                GenreId = 1,
                BookRatingId = 4,
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 3,
                Title = "The Lord of the Rings",
                AuthorId = 2,
                GenreId = 2,
                BookRatingId = 5,
            });

            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 1,
                AuthorName = "J.K. Rowling",
            });

            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 2,
                AuthorName = "J. R. R. Tolkien",
            });

            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 3,
                AuthorName = "Isaac Asimov",
            });

            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = 1,
                GenreName = "Sci-Fi",
            });

            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = 2,
                GenreName = "Fantasy",
            });

            modelBuilder.Entity<Genre>().HasData(new Genre
            {
                Id = 3,
                GenreName = "Thriller",
            });

            modelBuilder.Entity<BookRating>().HasData(new BookRating
            {
                Id = 1,
                Rating = "Very Bad (1)",
            });

            modelBuilder.Entity<BookRating>().HasData(new BookRating
            {
                Id = 2,
                Rating = "Bad (2)",
            });

            modelBuilder.Entity<BookRating>().HasData(new BookRating
            {
                Id = 3,
                Rating = "Ok (3)",
            });

            modelBuilder.Entity<BookRating>().HasData(new BookRating
            {
                Id = 4,
                Rating = "Good (4)",
            });

            modelBuilder.Entity<BookRating>().HasData(new BookRating
            {
                Id = 5,
                Rating = "Very Good (5)",
            });
        }
    }
}
