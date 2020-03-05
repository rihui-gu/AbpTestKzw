using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace WMS.Order.Dto
{
    [AutoMapFrom(typeof(Orders.Order))]
    public class OrderDto : EntityDto<long>
    {
    }
}
