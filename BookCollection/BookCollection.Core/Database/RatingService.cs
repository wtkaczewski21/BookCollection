namespace BookCollection.Core.Database
{
    public class RatingService<T> : IRatingService<T> where T : class
    {
        private readonly DesignTimeDbContextFactory _db;

        public RatingService(DesignTimeDbContextFactory db)
        {
            _db = db;
        }
        public IEnumerable<T> GetAllRatings()
        {
            using (BookCollectionDbContext dbContext = _db.CreateDbContext())
            {
                return dbContext.Set<T>().ToList();
            }
        }
    }
}
