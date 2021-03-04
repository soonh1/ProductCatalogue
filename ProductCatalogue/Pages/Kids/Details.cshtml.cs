using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductCatalogue.Data;
using ProductCatalogue.Models;

namespace ProductCatalogue.Pages.Kids
{
    public class DetailsModel : PageModel
    {
        private readonly ProductCatalogue.Data.ShopContext _context;

        public DetailsModel(ProductCatalogue.Data.ShopContext context)
        {
            _context = context;
        }

        public Kid Kid { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Kid = await _context.Kids
                .Include(k => k.Product)
                .Include(k => k.Type).FirstOrDefaultAsync(m => m.KidID == id);

            if (Kid == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
