namespace PassportView.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Repository")]
    public partial class Repository
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Repository()
        {
            ProductTypes = new HashSet<ProductType>();
        }

        [Key]
        public int FileId { get; set; }

        [Required]
        [StringLength(128)]
        public string Path { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? LastEdit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductType> ProductTypes { get; set; }
    }
}
