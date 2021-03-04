using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductCatalogue.Models;

namespace ProductCatalogue.Pages.Mens
{
    public class PantsModel : PageModel
    {
     
            private readonly ProductCatalogue.Data.ShopContext _context;

        public PantsModel(ProductCatalogue.Data.ShopContext context)
        {
            _context = context;
        }

        public IList<Men> Men { get; set; }

        public async Task OnGetAsync()
        {
            Men = await _context.Mens
                .Include(m => m.Product)
                .Include(m => m.Type).ToListAsync();
        }
    
    }
}
