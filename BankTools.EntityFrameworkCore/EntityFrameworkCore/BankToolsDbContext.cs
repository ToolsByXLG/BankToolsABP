using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BankTools.Authorization.Roles;
using BankTools.Authorization.Users;
using BankTools.MultiTenancy;

namespace BankTools.EntityFrameworkCore
{
    public class BankToolsDbContext : AbpZeroDbContext<Tenant, Role, User, BankToolsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BankToolsDbContext(DbContextOptions<BankToolsDbContext> options)
            : base(options)
        {
        }
    }
}
