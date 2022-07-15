using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BookCollection.Core.Database
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BookCollectionDbContext>, IDisposable
    {
        private BookCollectionDbContext _db;
        public BookCollectionDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<BookCollectionDbContext>();
            options.UseSqlServer("Server=.;Database=BookCollection;Trusted_Connection=True;");

            _db = new BookCollectionDbContext(options.Options);
            _db.Database.EnsureCreated();
            return _db;
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
