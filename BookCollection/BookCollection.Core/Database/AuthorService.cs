namespace BookCollection.Core.Database
{
    public class AuthorService<T> : IAuthorService<T> where T : class
    {
        private readonly DesignTimeDbContextFactory _db;

        public AuthorService(DesignTimeDbContextFactory db)
        {
            _db = db;
        }
        public IEnumerable<T> GetAllAuthors()
        {
            using (BookCollectionDbContext dbContext = _db.CreateDbContext())
            {
                return dbContext.Set<T>().ToList();
            }
        }
    }
}
