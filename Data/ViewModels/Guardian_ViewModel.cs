using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ViewModels
{
    public class Guardian_ViewModel
    {
        [Key]
        public int GuardinId { get; set; }
        public string Application_ID { get; set; }
        public string FullName { get; set; }
        public string Relationship { get; set; }
        public string Email { get; set; }
        public int MobileNumber { get; set; }
        public string Nationality { get; set; }
        public string IDPassportNumber { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public int PostalZip { get; set; }
    }
}
