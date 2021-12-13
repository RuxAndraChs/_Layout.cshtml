using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Chiselenco_Ruxandra_Lab5.Data;
using Chiselenco_Ruxandra_Lab5.Models;

namespace Chiselenco_Ruxandra_Lab5.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Chiselenco_Ruxandra_Lab5.Data.Chiselenco_Ruxandra_Lab5Context _context;

        public IndexModel(Chiselenco_Ruxandra_Lab5.Data.Chiselenco_Ruxandra_Lab5Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get; set; }
        public List<Book> Book { get; private set; }

        public async Task OnGetAsync()

        {
            
            Book = await _context.Book
                 .Include(b=>b.Publisher)
                 .ToListAsync();
        }
    }
    
}
