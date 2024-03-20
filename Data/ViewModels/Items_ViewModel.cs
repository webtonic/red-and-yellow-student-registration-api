using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ViewModels
{
    public class Items_ViewModel
    {
        [Key]
        public int ItemId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Price { get; set; }

    }
}
