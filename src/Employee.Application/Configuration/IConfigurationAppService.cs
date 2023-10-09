using System.Threading.Tasks;
using Employee.Configuration.Dto;

namespace Employee.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
