using System.Collections.Generic;
using Jgp.Issues.Roles.Dto;
using Jgp.Issues.Users.Dto;

namespace Jgp.Issues.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}