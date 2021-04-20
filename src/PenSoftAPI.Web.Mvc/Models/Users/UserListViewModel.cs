using System.Collections.Generic;
using PenSoftAPI.Roles.Dto;

namespace PenSoftAPI.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
