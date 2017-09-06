using System.Collections.Generic;
using Jgp.Issues.Roles.Dto;

namespace Jgp.Issues.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}