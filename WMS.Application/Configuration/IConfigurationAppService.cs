using System.Threading.Tasks;
using Abp.Application.Services;
using WMS.Configuration.Dto;

namespace WMS.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}