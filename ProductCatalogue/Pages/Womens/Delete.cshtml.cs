using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductCatalogue.Data;
using ProductCatalogue.Models;

namespace ProductCatalogue.Pages.Womens
{
    public class DeleteModel : PageModel
    {
        private readonly ProductCatalogue.Data.ShopContext _context;

        public DeleteModel(ProductCatalogue.Data.ShopContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Women Women { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Women = await _context.Womens
                .Include(w => w.Product)
                .Include(w => w.Type).FirstOrDefaultAsync(m => m.WomenID == id);

            if (Women == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Women = await _context.Womens.FindAsync(id);

            if (Women != null)
            {
                _context.Womens.Remove(Women);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
