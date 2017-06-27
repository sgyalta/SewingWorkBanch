namespace PassportView.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Color")]
    public partial class Color
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Color()
        {
            Materials = new HashSet<Material>();
            ProductProperties = new HashSet<ProductProperty>();
        }

        public int ColorId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int? R { get; set; }

        public int? G { get; set; }

        public int? B { get; set; }

        public int? A { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material> Materials { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductProperty> ProductProperties { get; set; }
    }
}
