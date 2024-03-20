using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data.ViewModels
{
    public class Applicant_ViewModel
    {
        [Key]
        public string Applicant_ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int MobileNumber { get; set; }
        public string EducationLevel { get; set; }
        public string Nationality { get; set; }
        public string IDPassportNumber { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public string LiableForPayment { get; set; }
        public string StreetAddress { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public int PostalZip { get; set; }
        public string ApplicationState { get; set; }
        public bool Complete { get; set; }
    }
}
