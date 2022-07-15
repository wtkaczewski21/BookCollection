namespace BookCollection.Core.Database
{
    public class GenreService<T> : IGenreService<T> where T : class
    {
        private readonly DesignTimeDbContextFactory _db;

        public GenreService(DesignTimeDbContextFactory db)
        {
            _db = db;
        }
        public IEnumerable<T> GetAllGenres()
        {
            using (BookCollectionDbContext dbContext = _db.CreateDbContext())
            {
                return dbContext.Set<T>().ToList();
            }
        }
    }
}
