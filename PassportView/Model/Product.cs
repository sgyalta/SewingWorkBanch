namespace PassportView.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            MaterialUseds = new HashSet<MaterialUsed>();
            OrderProducts = new HashSet<OrderProduct>();
            ProductMakers = new HashSet<ProductMaker>();
        }

        public int ProductId { get; set; }

        [Required]
        [StringLength(512)]
        public string Description { get; set; }

        [Required]
        [StringLength(13)]
        public string BarCode { get; set; }

        public int PropertyId { get; set; }

        [Column(TypeName = "money")]
        public decimal CostPrice { get; set; }

        public int Quantity { get; set; }

        public int StatusId { get; set; }

        public bool IsMade { get; set; }

        [Required]
        [StringLength(50)]
        public string SCU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialUsed> MaterialUseds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }

        public virtual ProductProperty ProductProperty { get; set; }

        public virtual ProductStatu ProductStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductMaker> ProductMakers { get; set; }
    }
}
