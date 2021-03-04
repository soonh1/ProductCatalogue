using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProductCatalogue.Data;
using ProductCatalogue.Models;

namespace ProductCatalogue.Pages.Womens
{
    public class CreateModel : PageModel
    {
        private readonly ProductCatalogue.Data.ShopContext _context;

        public CreateModel(ProductCatalogue.Data.ShopContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ProductID"] = new SelectList(_context.Products, "ID", "ID");
        ViewData["TypeID"] = new SelectList(_context.Types, "TypeID", "TypeID");
            return Page();
        }

        [BindProperty]
        public Women Women { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Womens.Add(Women);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
