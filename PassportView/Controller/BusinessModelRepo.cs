using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassportView.Model;
using PassportView.BusinessModel;

namespace PassportView.Controller
{
  public class BusinessModelRepo
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

        public List<WarehouseMaterials> GetWarehouseMaterials(string category)
        {
            return Connect.Materials.Where(x=>x.Category.Name == category).Select(x => new WarehouseMaterials
            {
                MaterialId = x.MaterialId,
                Name = x.Name,
                Category = x.Category.Name,
                Quantity = x.Quantity,
                CoastPrice = x.CoastPrice
            }).ToList();
        }
    }
}
