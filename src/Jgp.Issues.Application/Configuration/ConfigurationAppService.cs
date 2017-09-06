using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Jgp.Issues.Configuration.Dto;

namespace Jgp.Issues.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : IssuesAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
