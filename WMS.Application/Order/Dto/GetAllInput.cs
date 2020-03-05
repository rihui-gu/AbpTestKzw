using Abp.Application.Services.Dto;
using System;

namespace WMS.Order.Dto
{
    public class GetAllInput : PagedResultRequestDto
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public string No { get; set; }

        /// <summary>
        /// 客户
        /// </summary>
        public string Customer { get; set; }

        /// <summary>
        /// 下单时间开始
        /// </summary>
        public DateTime? BeginTime { get; set; }

        /// <summary>
        /// 下单时间结束
        /// </summary>
        public DateTime? EndTime { get; set; }

    }
}
