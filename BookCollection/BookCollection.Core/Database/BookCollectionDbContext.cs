using BookCollection.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace BookCollection.Core.Database
{
    public class BookCollectionDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public BookCollectionDbContext(DbContextOptions<BookCollectionDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
