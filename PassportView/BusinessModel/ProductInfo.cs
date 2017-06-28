using PassportView.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportView.BusinessModel
{
    public class ProductInfo
    {
        public ProductType ProductType { get; set; }
        public int IdColor { get; set; }
        public int IdSize { get; set; }

        public List<AssignedEmployees> AssignedEmployees { get; set; }
        public List<SelectedMaterial> SelectedMaterial { get; set; }

        public string Description { get; set; }
        public decimal CostPrice { get; set; }
        public double Quantity { get; set; }
        public int ProductStatusId { get; set; }
        public string SCU { get; set; }
        public string BarCode { get; set; }


        public override string ToString()
        {
            return $"{SCU,-5} {ProductType.Name,-5} {Quantity}шт - Заводская цена {CostPrice} uah";
        }
    }
}
