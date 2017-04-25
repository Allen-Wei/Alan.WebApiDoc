using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alan.WebApiDoc.Demonstration.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public String UserId { get; set; }
        public String Address { get; set; }
    }
}