using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Goron_Melisa_Lab8.Data;
using Goron_Melisa_Lab8.Models;

namespace Goron_Melisa_Lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Goron_Melisa_Lab8.Data.Goron_Melisa_Lab8Context _context;

        public IndexModel(Goron_Melisa_Lab8.Data.Goron_Melisa_Lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
