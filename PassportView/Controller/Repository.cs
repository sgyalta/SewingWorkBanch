using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassportView.Model;

namespace PassportView.Controller
{
  public class Repository
    {
      private  DbPassportContext Connect = new DbPassportContext();

        public List<OrdersModel> GetOrdersModels()
        {
            return Connect.Orders.Select(x => new OrdersModel
            {
                OrderNumber = x.OrderNumber,
                Custumer = x.Customer.Name,
                DateBegin = x.DateBegin,
                Expiress = x.Expiress,
                Status = x.ProductStatu.Name,
                CostPrice = x.CostPriceOrder
            }).ToList();
        }

        public List<Customer> GetCustomers()
        {
            return Connect.Customers.ToList();
        }
    }
}
