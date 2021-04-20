using System.Threading.Tasks;
using PenSoftAPI.Configuration.Dto;

namespace PenSoftAPI.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
