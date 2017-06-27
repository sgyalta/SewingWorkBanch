namespace PassportView.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaterialUsed")]
    public partial class MaterialUsed
    {
        public int MaterialUsedId { get; set; }

        public int MaterialId { get; set; }

        public double Quant { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalCoast { get; set; }

        public int ProductId { get; set; }

        public virtual Material Material { get; set; }

        public virtual Product Product { get; set; }
    }
}
