using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace BankTools.Controllers
{
    public abstract class BankToolsControllerBase: AbpController
    {
        protected BankToolsControllerBase()
        {
            LocalizationSourceName = BankToolsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
