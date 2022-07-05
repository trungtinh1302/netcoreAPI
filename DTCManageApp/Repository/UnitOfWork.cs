using DTCManageApp.Domain;
using DTCManageApp.Domain.AccountAggregate;
using DTCManageApp.Domain.AccountCategoryAggregate;
using DTCManageApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTCManageApp.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBContext db;
        public IAccountCategoryRepository AccountCategoryRepository { get; }

        public IAccountRepository AccountRepository { get; }

        public UnitOfWork(DBContext context, IAccountCategoryRepository _accountCategory, IAccountRepository _accounts)
        {
            db = context;
            AccountCategoryRepository = _accountCategory;
            AccountRepository = _accounts;
        }

        public async Task<int> Complete()
        {
            return await db.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
        }
    }
}
