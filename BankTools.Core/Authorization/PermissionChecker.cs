using Abp.Authorization;
using BankTools.Authorization.Roles;
using BankTools.Authorization.Users;

namespace BankTools.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
