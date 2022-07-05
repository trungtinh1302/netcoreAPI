using DTCManageApp.Domain.AccountAggregate;
using DTCManageApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTCManageApp.Repository
{
    public class AccountRepository : GenericRepository<Account>, IAccountRepository
    {
        public AccountRepository(DBContext context) : base(context)
        {
        }

        public async Task<int> Add(Account entity)
        {
            await db.Accounts.AddAsync(entity);
            return 1;
        }

        public async Task<bool> Delete(int id)
        {
            var account = await db.Accounts.FindAsync(id);

            if (account == null)
            {
                return false;
            }

            db.Accounts.Remove(account);
            return true;
        }

        public async Task<Account> Get(int id)
        {
            return await db.Accounts.FindAsync(id);
        }

        public async Task<IEnumerable<Account>> Gets()
        {
            return await db.Accounts.ToListAsync();
        }

        public async Task<bool> Update(Account entity)
        {
            var account = await db.Accounts.FindAsync(entity);

            if (account == null)
            {
                return false;
            }

            db.Entry(account).CurrentValues.SetValues(entity);
            return true;
        }
    }
}
