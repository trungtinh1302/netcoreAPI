using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTCManageApp.Domain
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetsGeneric();
        Task<T> GetGeneric(int id);
        Task<int> AddGeneric(T entity);
        Task<int> UpdateGeneric(T entity);
        Task<int> DeleteGeneric(int id);
    }
}
