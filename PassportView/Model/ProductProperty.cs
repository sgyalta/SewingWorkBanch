using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PassportView.Model
{
    [Table("ProductProperty")]
    public partial class ProductProperty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductProperty()
        {
            Products = new HashSet<Product>();
        }

        public int ProductPropertyId { get; set; }

        public int ColorId { get; set; }

        public int SizeId { get; set; }

        public int ProductTypeId { get; set; }

        public virtual Color Color { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }

        public virtual ProductType ProductType { get; set; }

        public virtual Size Size { get; set; }
    }
}
