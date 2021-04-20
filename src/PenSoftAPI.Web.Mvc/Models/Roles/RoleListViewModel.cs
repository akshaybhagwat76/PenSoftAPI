using System.Collections.Generic;
using PenSoftAPI.Roles.Dto;

namespace PenSoftAPI.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
