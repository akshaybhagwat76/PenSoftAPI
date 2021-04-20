using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using PenSoftAPI.Configuration.Dto;

namespace PenSoftAPI.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PenSoftAPIAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
