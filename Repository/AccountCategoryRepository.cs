using Domain;
using Domain.AccountCategoryAggregate;
using DTCManageApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AccountCategoryRepository : IAccountCategoryRepository
    {
        private readonly DBContext db;
        public AccountCategoryRepository(DBContext context)
        {
            db = context;
        }
        public async Task<int> Add(AccountCategory entity)
        {
            try
            {
                await db.AccountCategories.AddAsync(entity);
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public async Task<int> Delete(int id)
        {
            try
            {
                var accountCat = await db.AccountCategories.FindAsync(id);
                db.AccountCategories.Remove(accountCat);
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public async Task<AccountCategory> Get(int id)
        {
            return await db.AccountCategories.FindAsync(id);
        }

        public async Task<IEnumerable<AccountCategory>> Gets()
        {
            return await db.AccountCategories.ToListAsync();
        }

        public async Task<int> Update(AccountCategory entity)
        {
            try
            {
                var accountCat = await db.AccountCategories.FindAsync(entity);
                db.Entry(accountCat).CurrentValues.SetValues(entity);
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
