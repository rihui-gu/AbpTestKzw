using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;

namespace WMS.Orders
{
    public class Order : FullAuditedEntity<long>, IMustHaveTenant
    {
        public int TenantId { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string No { get; set; }

        /// <summary>
        /// 客户
        /// </summary>
        public string Customer { get; set; }

        /// <summary>
        /// 收货地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        public DateTime OrderTime { get; set; }

        /// <summary>
        /// 发货时间
        /// </summary>
        public DateTime? DeliveryTime { get; set; }
    }
}
