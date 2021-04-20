using Abp.AutoMapper;
using PenSoftAPI.Roles.Dto;
using PenSoftAPI.Web.Models.Common;

namespace PenSoftAPI.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
