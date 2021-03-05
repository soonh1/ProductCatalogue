using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductCatalogue.Models;

namespace ProductCatalogue.Pages.Womens
{
    public class ShoeModel : PageModel
    {
        private readonly ProductCatalogue.Data.ShopContext _context;

        public ShoeModel(ProductCatalogue.Data.ShopContext context)
        {
            _context = context;
        }

        public IList<Women> Women { get; set; }

        public async Task OnGetAsync()
        {
            Women = await _context.Womens
                .Include(w => w.Product)
                .Include(w => w.Type).ToListAsync();
        }
    }
}
