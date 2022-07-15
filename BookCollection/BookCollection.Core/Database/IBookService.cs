namespace BookCollection.Core.Database
{
    public interface IBookService<T> where T : class
    {
        T GetBookById(int id);
        IEnumerable<T> GetAllBooks();
        T AddBook(T book);
        void DeleteBook(int id);
    }
}
