﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductCatalogue.Data;
using ProductCatalogue.Models;

namespace ProductCatalogue.Pages.Mens
{
    public class DeleteModel : PageModel
    {
        private readonly ProductCatalogue.Data.ShopContext _context;

        public DeleteModel(ProductCatalogue.Data.ShopContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Men Men { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Men = await _context.Mens
                .Include(m => m.Product)
                .Include(m => m.Type).FirstOrDefaultAsync(m => m.MenID == id);

            if (Men == null)
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

            Men = await _context.Mens.FindAsync(id);

            if (Men != null)
            {
                _context.Mens.Remove(Men);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
