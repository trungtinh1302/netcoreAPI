using DTCManageApp.Domain.AccountAggregate;
using DTCManageApp.Domain.AccountCategoryAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTCManageApp.Model
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }

        public virtual DbSet<AccountCategory> AccountCategories { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
    }
}
