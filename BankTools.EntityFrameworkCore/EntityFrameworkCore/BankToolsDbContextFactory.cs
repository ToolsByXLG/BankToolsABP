using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using BankTools.Configuration;
using BankTools.Web;

namespace BankTools.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BankToolsDbContextFactory : IDesignTimeDbContextFactory<BankToolsDbContext>
    {
        public BankToolsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BankToolsDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            BankToolsDbContextConfigurer.Configure(builder, configuration.GetConnectionString(BankToolsConsts.ConnectionStringName));

            return new BankToolsDbContext(builder.Options);
        }
    }
}
