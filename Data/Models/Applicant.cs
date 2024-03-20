using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.Models
{
    [Table("applicant")]
    public partial class Applicant
    {
        public Applicant()
        {
            Guardians = new HashSet<Guardian>();
        }

        [Key]
        [Column("Applicant_ID")]
        [StringLength(512)]
        public string ApplicantId { get; set; } = null!;
        [Column("Full Name")]
        [StringLength(45)]
        public string? FullName { get; set; }
        [StringLength(45)]
        public string? Email { get; set; }
        [Column("Mobile Number")]
        public int? MobileNumber { get; set; }
        [Column("Education Level")]
        [StringLength(45)]
        public string? EducationLevel { get; set; }
        [StringLength(45)]
        public string? Nationality { get; set; }
        [Column("IDNumber/PassportNumber")]
        [StringLength(45)]
        public string? IdnumberPassportNumber { get; set; }
        [StringLength(45)]
        public string? Gender { get; set; }
        [StringLength(45)]
        public string? Race { get; set; }
        [StringLength(45)]
        public string? LiableForPayment { get; set; }
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
        [Column("Application State")]
        [StringLength(45)]
        public string? ApplicationState { get; set; }
        [StringLength(45)]
        public string? Complete { get; set; }

        [InverseProperty("Applicant")]
        public virtual ICollection<Guardian> Guardians { get; set; }
    }
}
