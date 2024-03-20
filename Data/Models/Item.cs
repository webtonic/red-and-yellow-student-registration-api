using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.Models
{
    [Table("items")]
    public partial class Item
    {
        public Item()
        {
            Carts = new HashSet<Cart>();
        }

        [Key]
        public int ItemId { get; set; }
        [StringLength(45)]
        public string? CourseName { get; set; }
        [StringLength(45)]
        public string? Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Precision(18, 2)]
        public decimal? Price { get; set; }

        [InverseProperty("Item")]
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
