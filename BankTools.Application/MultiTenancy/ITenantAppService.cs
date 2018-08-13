using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BankTools.MultiTenancy.Dto;

namespace BankTools.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
