namespace BookCollection.Core.Database
{
    public interface IAuthorService<T> where T : class
    {
        IEnumerable<T> GetAllAuthors();
    }
}
