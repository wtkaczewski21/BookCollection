namespace BookCollection.Core.Database
{
    public class BookService<T> : IBookService<T> where T : class
    {
        private readonly DesignTimeDbContextFactory _db;

        public BookService(DesignTimeDbContextFactory db)
        {
            _db = db;
        }

        public T AddBook(T book)
        {
            using (BookCollectionDbContext dbContext = _db.CreateDbContext())
            {
                dbContext.Set<T>().Add(book);
                dbContext.SaveChanges();

                return book;
            }
        }

        public void DeleteBook(int id)
        {
            using (BookCollectionDbContext dbContext = _db.CreateDbContext())
            {
                var found = dbContext.Set<T>().Find(id);
                dbContext.Set<T>().Remove(found);
                dbContext.SaveChanges();
            }
        }

        public IEnumerable<T> GetAllBooks()
        {
            using (BookCollectionDbContext dbContext = _db.CreateDbContext())
            {
                return dbContext.Set<T>().ToList();
            }
        }

        public T GetBookById(int id)
        {
            using (BookCollectionDbContext dbContext = _db.CreateDbContext())
            {
                return dbContext.Set<T>().Find(id);
            }
        }
    }
}
