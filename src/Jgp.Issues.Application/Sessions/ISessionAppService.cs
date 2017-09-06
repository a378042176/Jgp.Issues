using System.Threading.Tasks;
using Abp.Application.Services;
using Jgp.Issues.Sessions.Dto;

namespace Jgp.Issues.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
