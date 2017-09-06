using System.Threading.Tasks;
using Abp.Application.Services;
using Jgp.Issues.Configuration.Dto;

namespace Jgp.Issues.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}