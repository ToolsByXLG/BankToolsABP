using System.Collections.Generic;
using BankTools.Roles.Dto;
using BankTools.Users.Dto;

namespace BankTools.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
