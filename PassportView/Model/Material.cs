namespace PassportView.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Material")]
    public partial class Material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Material()
        {
            MaterialUseds = new HashSet<MaterialUsed>();
        }

        public int MaterialId { get; set; }

        public double Quantity { get; set; }

        [StringLength(50)]
        public string BarCode { get; set; }

        public int? ColorId { get; set; }

        public int ProviderId { get; set; }

        [Column(TypeName = "money")]
        public decimal CoastPrice { get; set; }

        public int CategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual Category Category { get; set; }

        public virtual Color Color { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialUsed> MaterialUseds { get; set; }

        public virtual Provider Provider { get; set; }
    }
}
