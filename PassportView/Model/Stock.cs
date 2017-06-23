using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PassportView.Model
{
    [Table("Stock")]
    public partial class Stock
    {
        [Key]
        [Column(Order = 0)]
        public int ProductId { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool InStok { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime IncomingDate { get; set; }

        public DateTime? OutGoing { get; set; }
    }
}
