using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportView.BusinessModel
{
    public class OrderProductDeteil
    {
        public int OrderId;
        [DisplayName("Наименования изделия")]
        public string NameProdectType { get; set; }
        [DisplayName("Артикул")]
        public string SCU { get; set; }
        [DisplayName("Размер")]
        public string Size { get; set; }
        [DisplayName("Кол-во шт/м")]
        public double Quantity { get; set; }
        [DisplayName("Себестоимость")]
        public decimal PriceCoast { get; set; }
        [DisplayName("Статус")]
        public string StatusName { get; set; }
    }
}
