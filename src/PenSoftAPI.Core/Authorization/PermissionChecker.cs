using Abp.Authorization;
using PenSoftAPI.Authorization.Roles;
using PenSoftAPI.Authorization.Users;

namespace PenSoftAPI.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
