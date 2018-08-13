using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BankTools.EntityFrameworkCore
{
    public static class BankToolsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BankToolsDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BankToolsDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
