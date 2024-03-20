using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.Models
{
    [Table("cart")]
    [Index("ItemId", Name = "ItemId_idx")]
    public partial class Cart
    {
        [Key]
        public int CartId { get; set; }
        public int? ItemId { get; set; }
        [Precision(18, 2)]
        public decimal? SubTotal { get; set; }
        [Precision(18, 2)]
        public decimal? Tax { get; set; }
        [Precision(18, 2)]
        public decimal? FinalTotal { get; set; }
        [StringLength(45)]
        public string? PaymentType { get; set; }
        public sbyte? PaymentComplete { get; set; }
        [StringLength(512)]
        public string? PaymentId { get; set; }

        [ForeignKey("ItemId")]
        [InverseProperty("Carts")]
        public virtual Item? Item { get; set; }
    }
}
