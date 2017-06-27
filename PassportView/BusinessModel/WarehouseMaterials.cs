using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportView.BusinessModel
{
    public class WarehouseMaterials
    {
        public int MaterialId { get; set; }
        [DisplayName("Материалы")]
        public string Name { get; set; }
        public int CategoryId;
        [DisplayName("Кол-во шт/м")]
        public double Quantity { get; set; }
        [DisplayName("Себестоимость за ед. uah")]
        public decimal CoastPrice { get; set; }
    }
}