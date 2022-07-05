using DTCManageApp.Domain.AccountAggregate;
using DTCManageApp.Domain.AccountCategoryAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTCManageApp.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        IAccountCategoryRepository AccountCategoryRepository { get; }
        IAccountRepository AccountRepository { get; }
        Task<int> Complete();
    }
}
