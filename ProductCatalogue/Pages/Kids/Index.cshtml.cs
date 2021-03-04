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
    public class IndexModel : PageModel
    {
        private readonly ProductCatalogue.Data.ShopContext _context;

        public IndexModel(ProductCatalogue.Data.ShopContext context)
        {
            _context = context;
        }

        public IList<Kid> Kid { get;set; }

        public async Task OnGetAsync()
        {
            Kid = await _context.Kids
                .Include(k => k.Product)
                .Include(k => k.Type).ToListAsync();
        }
    }
}
