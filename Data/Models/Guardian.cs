using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.Models
{
    [Table("guardian")]
    [Index("ApplicantId", Name = "Applicant_ID_idx")]
    public partial class Guardian
    {
        [Key]
        public int GuardianId { get; set; }
        [StringLength(512)]
        public string? ApplicantId { get; set; }
        [Column("Full Name")]
        [StringLength(45)]
        public string? FullName { get; set; }
        [StringLength(45)]
        public string? Relationship { get; set; }
        [StringLength(45)]
        public string? Email { get; set; }
        [Column("Mobile Number")]
        public int? MobileNumber { get; set; }
        [StringLength(45)]
        public string? Nationality { get; set; }
        [Column("IDNumber/PassportNumber")]
        public int? IdnumberPassportNumber { get; set; }
        [Column("Street Address")]
        [StringLength(45)]
        public string? StreetAddress { get; set; }
        [StringLength(45)]
        public string? Country { get; set; }
        [StringLength(45)]
        public string? City { get; set; }
        [StringLength(45)]
        public string? Province { get; set; }
        [Column("Postal Zip")]
        [StringLength(45)]
        public string? PostalZip { get; set; }
        [StringLength(45)]
        public string? Guardiancol { get; set; }

        [ForeignKey("ApplicantId")]
        [InverseProperty("Guardians")]
        public virtual Applicant? Applicant { get; set; }
    }
}
