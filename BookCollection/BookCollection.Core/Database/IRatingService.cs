namespace BookCollection.Core.Database
{
    public interface IRatingService<T> where T : class
    {
        IEnumerable<T> GetAllRatings();
    }
}
