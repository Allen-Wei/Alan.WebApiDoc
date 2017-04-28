using Alan.WebApiDoc.Demonstration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Alan.WebApiDoc.Demonstration.API
{
    /// <summary>
    /// Order API
    /// </summary>
    public class OrderController : ApiController
    {
        /// <summary>
        /// Get All Orders
        /// </summary>
        /// <returns></returns>
        public List<Order> Get()
        {
            return new List<Order>();
        }
        /// <summary>
        /// Query order by order id
        /// </summary>
        /// <param name="id">Order id</param>
        /// <returns-fail>
        /// {
        ///     success: bool/false,
        ///     message: string
        /// }
        /// </returns-fail>
        /// <returns>
        /// {
        ///     success: bool,
        ///     message: string,
        ///     data: [{
        ///         fn: string,
        ///         ln: string
        ///     }]
        /// }
        /// </returns>
        public Order Get(int id)
        {
            return new Order();
        }
        /// <summary>
        /// Delete order by order id
        /// </summary>
        /// <param name="id">Order id</param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            return true;
        }

        /// <summary>
        /// 新增订单
        /// </summary>
        /// <param name="order">订单信息</param>
        /// <returns></returns>
        public bool Post(Order order)
        {

            return true;
        }
    }
}
