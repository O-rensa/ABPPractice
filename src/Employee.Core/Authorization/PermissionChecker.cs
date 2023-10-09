using Abp.Authorization;
using Employee.Authorization.Roles;
using Employee.Authorization.Users;

namespace Employee.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
