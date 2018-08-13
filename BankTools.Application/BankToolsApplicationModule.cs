using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BankTools.Authorization;

namespace BankTools
{
    [DependsOn(
        typeof(BankToolsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BankToolsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<BankToolsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(BankToolsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
