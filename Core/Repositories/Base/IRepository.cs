using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Repositories.Base
{
    public interface IRepository <T> where T: class
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}