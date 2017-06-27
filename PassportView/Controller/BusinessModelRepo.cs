using PassportView.BusinessModel;
using PassportView.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportView.Controller
{
    public class BusinessModelRepo
    {
        DbPassportContext Connect = new DbPassportContext();

        public List<WarehouseMaterials> GetWarehouseMaterials(int id)
        {
            return Connect.Materials.Where(x => x.CategoryId == id).Select(x => new WarehouseMaterials
            {
                MaterialId = x.MaterialId,
                Name = x.Name,
                CategoryId = x.CategoryId,
                Quantity = x.Quantity,
                CoastPrice = x.CoastPrice
            }).ToList();
        }

        public List<OrdersModel> GetOrdersModel()
        {
            return Connect.Orders.Select(x => new OrdersModel
            {
                OrderId = x.OrderId,
                OrderNumber = x.OrderNumber,
                Custumer = x.Customer.Name,
                DateBegin = DateTime.Now,
                Expiress = x.Expiress,
                Status = x.ProductStatu.Name,
                CostPrice = x.CostPriceOrder
            }).ToList();
        }
    }
}
