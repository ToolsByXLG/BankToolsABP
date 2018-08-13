using System.Collections.Generic;
using BankTools.Roles.Dto;

namespace BankTools.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}