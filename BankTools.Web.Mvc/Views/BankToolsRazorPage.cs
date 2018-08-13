using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace BankTools.Web.Views
{
    public abstract class BankToolsRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected BankToolsRazorPage()
        {
            LocalizationSourceName = BankToolsConsts.LocalizationSourceName;
        }
    }
}
