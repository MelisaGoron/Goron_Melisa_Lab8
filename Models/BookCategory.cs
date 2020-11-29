using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Goron_Melisa_Lab8.Models
{
    public class BookCategory
    {
        public int ID { get; set; }
        public int BookID { get; set; }
       // [Display(Name = "Book Title")]
        public Book Book { get; set; }
        public int CategoryID { get; set; }
       // [Display(Name = "Book Category")]
        public Category Category { get; set; }
    }
}
