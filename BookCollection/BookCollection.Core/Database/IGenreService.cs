namespace BookCollection.Core.Database
{
    public interface IGenreService<T> where T : class
    {
        IEnumerable<T> GetAllGenres();
    }
}
