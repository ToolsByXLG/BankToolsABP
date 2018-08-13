using System.Threading.Tasks;
using BankTools.Configuration.Dto;

namespace BankTools.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
