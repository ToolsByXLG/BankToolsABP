using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using BankTools.Configuration.Dto;

namespace BankTools.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BankToolsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
