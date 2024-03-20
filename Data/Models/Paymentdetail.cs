using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.Models
{
    [Table("paymentdetails")]
    public partial class Paymentdetail
    {
        [Key]
        [StringLength(512)]
        [MySqlCharSet("utf8mb3")]
        [MySqlCollation("utf8mb3_general_ci")]
        public string PaymentId { get; set; } = null!;
        [StringLength(45)]
        public string? Type { get; set; }
        [Column("result")]
        [StringLength(45)]
        public string? Result { get; set; }
        [Column("message")]
        [StringLength(45)]
        public string? Message { get; set; }
        public sbyte? Success { get; set; }
    }
}
