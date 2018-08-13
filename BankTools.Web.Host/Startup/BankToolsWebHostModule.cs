using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BankTools.Configuration;

namespace BankTools.Web.Host.Startup
{
    [DependsOn(
       typeof(BankToolsWebCoreModule))]
    public class BankToolsWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public BankToolsWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BankToolsWebHostModule).GetAssembly());
        }
    }
}
