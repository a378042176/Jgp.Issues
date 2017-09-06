using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Jgp.Issues.Roles.Dto;
using Jgp.Issues.Users.Dto;

namespace Jgp.Issues.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}