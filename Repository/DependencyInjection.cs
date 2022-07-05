using Domain.AccountAggregate;
using Domain.AccountCategoryAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IAccountCategoryRepository, AccountCategoryRepository>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            return services;
        }
    }
}
