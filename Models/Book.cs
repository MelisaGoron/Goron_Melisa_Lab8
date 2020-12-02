using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Goron_Melisa_Lab8.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        [Required, StringLength(150, MinimumLength = 3)]

        public string Title { get; set; }
        [RegularExpression(@"^[A-Z][a-z]+\s[A-Z][a-z]+$", ErrorMessage = "Numele autorului trebuie sa fie de forma 'Prenume Nume'"), Required, StringLength(50, MinimumLength = 3)]

        public string Author { get; set; }
        [Range(1, 300)]

        [Column(TypeName = "decimal(6, 2)")]

        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int PublisherID { get; set; }//cs dintre book spre 
        public Publisher Publisher { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
       // public int BookCategoryID { get; set; }

       // public BookCategory BookCategory { get; set; }

    }

}
