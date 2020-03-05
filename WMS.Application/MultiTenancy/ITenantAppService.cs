using Abp.Application.Services;
using Abp.Application.Services.Dto;
using WMS.MultiTenancy.Dto;

namespace WMS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
