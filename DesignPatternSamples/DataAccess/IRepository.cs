namespace DesignPatternSamples.DataAccess
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T?> GetByIdAsync(int id);

        Task<T> AddAsync(T entity);

        T Update(T entity);

        Task DeleteAsync(int id);

        int SaveChanges();
    }
}