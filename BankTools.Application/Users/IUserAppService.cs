using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BankTools.Roles.Dto;
using BankTools.Users.Dto;

namespace BankTools.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
