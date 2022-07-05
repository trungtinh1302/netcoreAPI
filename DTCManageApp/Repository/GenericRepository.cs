using DTCManageApp.Domain;
using DTCManageApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTCManageApp.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DBContext db;
        public GenericRepository(DBContext context)
        {
            db = context;
        }

        public Task<int> AddGeneric(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteGeneric(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetGeneric(int id)
        {
            return await db.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetsGeneric()
        {
            return await db.Set<T>().ToListAsync();
        }

        public Task<int> UpdateGeneric(T entity)
        {
            throw new NotImplementedException();
        }

        public int Edit(T entity)
        {
            db.Set<T>().Update(entity);
            return 1;
        }
    }
}
