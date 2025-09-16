using Core.Models;

namespace Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<IReadOnlyList<T>> GetReponseAsync<TParam>(TParam parameter);
        Task<PagedResponse<IReadOnlyList<T>>> GetPagedReponseAsync<TParam>(TParam parameter) where TParam : BaseRequest;
        Task<PagedResponse<IReadOnlyList<TModel>>> GetModelPagedReponseAsync<TParam, TModel>(TParam parameter)
            where TModel : class, new()
            where TParam : BaseRequest;
        Task<T> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entities);
        Task<bool> UpdateAsync(T entity);
        Task<bool> UpdateRangeAsync(List<T> entities);
        Task<bool> DeleteAsync(T entity);
        Task<bool> DeleteRangeAsync(List<T> entities);
    }
}
