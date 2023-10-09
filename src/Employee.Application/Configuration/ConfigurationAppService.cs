using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Employee.Configuration.Dto;

namespace Employee.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : EmployeeAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
