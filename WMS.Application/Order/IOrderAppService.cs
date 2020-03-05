using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System.Threading.Tasks;
using WMS.Order.Dto;

namespace WMS.Order
{
    public interface IOrderAppService : IAsyncCrudAppService<OrderDto, long, PagedResultRequestDto, OrderDto, OrderDto>
    {
        Task<PagedResultDto<OrderDto>> GetAll(GetAllInput input);

        Task<OrderDto> CreateOrder(OrderDto input);

        Task<OrderDto> UpdateOrder(OrderDto input);

        Task<bool> DeleteOrder(OrderDto input);
    }
}
