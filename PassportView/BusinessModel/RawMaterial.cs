using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportView.BusinessModel
{
    public class RawMaterial
    {
        [DisplayName("ID")]
        public int MaterialId { get; set; }
        [DisplayName("Наименование")]
        public string Name { get; set; }
        [DisplayName("Штрих код")]
        public string BarCode { get; set; }
        [DisplayName("Кол-во шт/м")]
        public double Quantity { get; set; }
        [DisplayName("Цвет")]
        public string ColorName { get; set; }
        [DisplayName("Категория")]
        public string CategoryName { get; set; }
        [DisplayName("Поставщик")]
        public string ProviderName { get; set; }    
    }
}
