using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain
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
