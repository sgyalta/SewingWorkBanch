namespace PassportView.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductMaker")]
    public partial class ProductMaker
    {
        [Key]
        public int ProductMakersId { get; set; }

        public int EmloyeeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExperiesDay { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
