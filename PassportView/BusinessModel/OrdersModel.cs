using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportView
{
  public class OrdersModel
    {
        public int OrderId;
        [DisplayName("Номер заказа")]
        public string OrderNumber { get; set; }
        [DisplayName("Заказчик")]
        public string Custumer { get; set; }
        [DisplayName("Начало")]
        public DateTime DateBegin { get; set; }
        [DisplayName("Конец")]
        public DateTime Expiress { get; set; }
        [DisplayName("Статус")]
        public string Status { get; set; }
        [DisplayName("Себестоимость заказа")]
        public decimal CostPrice { get; set; }
    }
}
