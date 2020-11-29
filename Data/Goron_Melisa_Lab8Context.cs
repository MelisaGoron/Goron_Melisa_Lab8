using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Goron_Melisa_Lab8.Models;

namespace Goron_Melisa_Lab8.Data
{
    public class Goron_Melisa_Lab8Context : DbContext
    {
        public Goron_Melisa_Lab8Context (DbContextOptions<Goron_Melisa_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Goron_Melisa_Lab8.Models.Book> Book { get; set; }

        public DbSet<Goron_Melisa_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Goron_Melisa_Lab8.Models.Category> Category { get; set; }

        public DbSet<Goron_Melisa_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
