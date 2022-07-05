using DTCManageApp.Domain.AccountAggregate;
using DTCManageApp.Domain.AccountCategoryAggregate;
using DTCManageApp.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTCManageApp.Repository
{
    public static class DependencyInjection
    {
        public static IConfiguration Configuration { get; }
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IAccountCategoryRepository, AccountCategoryRepository>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            return services;
        }
    }
}
