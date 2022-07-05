using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AccountAggregate
{
    public interface IAccountRepository: IGenericRepository<Account>
    {
        Task<Account> Get(int id);
        Task<IEnumerable<Account>> Gets();
        Task<int> Add(Account entity);
        Task<bool> Delete(int id);
        Task<bool> Update(Account bookEntity);
    }
}
