using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTCManageApp.Domain.AccountCategoryAggregate
{
    public interface IAccountCategoryRepository : IGenericRepository<AccountCategory>
    {
        Task<IEnumerable<AccountCategory>> GetAll();
        Task<AccountCategory> Get(int id);
        Task<bool> Create(AccountCategory entity);
    }
}
