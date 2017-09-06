using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Jgp.Issues.MultiTenancy.Dto;

namespace Jgp.Issues.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
