using Core.Extensions.Objects;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContext _dbContext;

        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<bool> UpdateAsync(T entity)
        {
            try
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public virtual async Task<bool> DeleteAsync(T entity)
        {
            try
            {
                _dbContext.Set<T>().Remove(entity);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public virtual async Task<bool> DeleteRangeAsync(List<T> entities)
        {
            try
            {
                _dbContext.Set<T>().RemoveRange(entities);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public virtual async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbContext
                 .Set<T>()
                 .ToListAsync();
        }

        public virtual async Task<IReadOnlyList<T>> GetReponseAsync<TParam>(TParam parameter)
        {
            return await _dbContext.Set<T>()
                .Filter(parameter)
                .AsNoTracking()
                .ToListAsync();
        }

        public virtual async Task<PagedResponse<IReadOnlyList<T>>> GetPagedReponseAsync<TParam>(TParam parameter) where TParam : BaseRequest
        {
            var response = new PagedResponse<IReadOnlyList<T>>();
            var query = _dbContext.Set<T>().Filter(parameter);
            response.Result.TotalCount = await query.CountAsync();
            response.Result.Items = await query.AsNoTracking()
                .Paged(parameter.SkipCount, parameter.MaxResultCount)
                .ToListAsync();
            return response;
        }

        public virtual async Task<PagedResponse<IReadOnlyList<TModel>>> GetModelPagedReponseAsync<TParam, TModel>(TParam parameter)
            where TModel : class, new()
            where TParam : BaseRequest
        {
            var response = new PagedResponse<IReadOnlyList<TModel>>();
            var query = _dbContext.Set<T>().Filter(parameter);
            response.Result.TotalCount = await query.CountAsync();
            response.Result.Items = await query.AsNoTracking()
                    .Paged(parameter.SkipCount, parameter.MaxResultCount)
                    .ProjectTo<T, TModel>()
                    .ToListAsync();
            return response;
        }

        public virtual async Task<bool> UpdateRangeAsync(List<T> entities)
        {
            try
            {
                foreach (var entity in entities)
                {
                    _dbContext.Entry(entity).State = EntityState.Modified;
                }
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public virtual async Task<bool> AddRangeAsync(List<T> entities)
        {
            bool result = true;
            using (var transaction = await _dbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    await _dbContext.Set<T>().AddRangeAsync(entities);
                    await _dbContext.SaveChangesAsync();
                    await transaction.CommitAsync();
                }
                catch
                {
                    result = false;
                    await transaction.RollbackAsync();
                }
            }

            return result;
        }
    }
}
