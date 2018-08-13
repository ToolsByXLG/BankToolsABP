using Abp.AspNetCore.Mvc.ViewComponents;

namespace BankTools.Web.Views
{
    public abstract class BankToolsViewComponent : AbpViewComponent
    {
        protected BankToolsViewComponent()
        {
            LocalizationSourceName = BankToolsConsts.LocalizationSourceName;
        }
    }
}
