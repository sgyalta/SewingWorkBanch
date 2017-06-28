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

        public List<OrdersModel> GetOrdersModels()
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

        public OrdersModel GetOrdersModel(int id)
        {
            return Connect.Orders.Where(x => x.OrderId == id).Select(x => new OrdersModel
            {
                OrderId = x.OrderId,
                OrderNumber = x.OrderNumber,
                Custumer = x.Customer.Name,
                DateBegin = DateTime.Now,
                Expiress = x.Expiress,
                Status = x.ProductStatu.Name,
                CostPrice = x.CostPriceOrder
            }).FirstOrDefault();
        }

        public List<RawMaterial> GetRawMaterials()
        {
            return Connect.Materials.Select(x => new RawMaterial
            {
                MaterialId = x.MaterialId,
                Name = x.Name,
                BarCode = x.BarCode,
                Quantity = x.Quantity,
                ColorName = x.Color.Name,
                CategoryName = x.Category.Name,
                ProviderName = x.Provider.Name
            }).ToList();
        }
    }
}
