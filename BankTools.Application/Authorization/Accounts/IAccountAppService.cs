using System.Threading.Tasks;
using Abp.Application.Services;
using BankTools.Authorization.Accounts.Dto;

namespace BankTools.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
