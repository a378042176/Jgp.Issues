using Abp.Authorization;
using Jgp.Issues.Authorization.Roles;
using Jgp.Issues.Authorization.Users;

namespace Jgp.Issues.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
