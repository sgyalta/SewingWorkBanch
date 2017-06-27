using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportView
{
  public class OrdersModel
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public string Custumer { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime Expiress { get; set; }
        public string Status { get; set; }
        public decimal CostPrice { get; set; }
    }
}
