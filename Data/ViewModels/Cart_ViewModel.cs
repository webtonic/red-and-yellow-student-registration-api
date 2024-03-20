using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ViewModels
{
    public class Cart_ViewModel
    {
        [Key]
        public int CartId { get; set; }
        public int ItemId { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal FinalTotal { get; set; }
        public int PaymentType { get; set; }
        public int PaymentId { get; set; }
        public bool PaymentComplete { get; set; }
    }
}
