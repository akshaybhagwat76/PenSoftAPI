using System.Collections.Generic;
using PenSoftAPI.Roles.Dto;

namespace PenSoftAPI.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}