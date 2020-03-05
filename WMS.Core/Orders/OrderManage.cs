using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Specifications;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace WMS.Orders
{
    public class OrderManage : IDomainService
    {
        private readonly IRepository<Order, long> _repository;
        public OrderManage(IRepository<Order, long> repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// 获取所有订单列表
        /// </summary>
        /// <param name="no">订单号</param>
        /// <param name="customer">客户</param>
        /// <param name="beginDate">下单时间(开始)</param>
        /// <param name="endDate">下单时间(结束)</param>
        /// <returns></returns>
        public IQueryable<Order> GetAll(string no, string customer, DateTime? beginDate, DateTime? endDate)
        {
            Expression<Func<Order, bool>> whereFilter = w => true;
            if (!string.IsNullOrWhiteSpace(no))
            {
                whereFilter.And(t => t.No.Contains(no));
            }

            if (!string.IsNullOrWhiteSpace(customer))
            {
                whereFilter.And(t => t.Customer.Contains(customer));
            }

            if (beginDate.HasValue)
            {
                whereFilter.And(t => t.OrderTime >= beginDate);
            }

            if (endDate.HasValue)
            {
                whereFilter.And(t => t.OrderTime <= endDate);
            }
            return _repository.GetAll().Where(whereFilter);
        }

        public Order UpdateOrder(Order input)
        {
            throw new NotImplementedException();
        }

        public Order CreateOrder(Order input)
        {
            throw new NotImplementedException();
        }

        public bool DeleteOrder(Order input)
        {
            throw new NotImplementedException();
        }
    }
}
