using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Chiselenco_Ruxandra_Lab5.Data;
using Chiselenco_Ruxandra_Lab5.Models;

namespace Chiselenco_Ruxandra_Lab5.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Chiselenco_Ruxandra_Lab5.Data.Chiselenco_Ruxandra_Lab5Context _context;

        public CreateModel(Chiselenco_Ruxandra_Lab5.Data.Chiselenco_Ruxandra_Lab5Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
