using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Order.Dto;
using WMS.Orders;

namespace WMS.Order
{
    public class OrderAppService : AsyncCrudAppService<Orders.Order, OrderDto, long, PagedResultRequestDto, OrderDto, OrderDto>, IOrderAppService
    {
        private readonly OrderManage _orderManage;

        protected OrderAppService(
            IRepository<Orders.Order, long> repository,
            OrderManage orderManage
        ) : base(repository)
        {
            _orderManage = orderManage;
        }

        /// <summary>
        /// 分页获取订单列表
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Task<PagedResultDto<OrderDto>> GetAll(GetAllInput input)
        {
            var query = _orderManage.GetAll(input.No, input.Customer, input.BeginTime, input.EndTime);
            var result = query.OrderByDescending(o => o.Id)
                        .Skip(input.SkipCount)
                        .Take(input.MaxResultCount);

            return Task.FromResult(new PagedResultDto<OrderDto>
            {
                TotalCount = result.Count(),
                Items = ObjectMapper.Map<List<OrderDto>>(query)
            });
        }

        public Task<OrderDto> UpdateOrder(OrderDto input)
        {
            throw new System.NotImplementedException();
        }

        public Task<OrderDto> CreateOrder(OrderDto input)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteOrder(OrderDto input)
        {
            throw new System.NotImplementedException();
        }
    }
}
