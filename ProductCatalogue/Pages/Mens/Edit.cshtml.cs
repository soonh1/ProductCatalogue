﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductCatalogue.Data;
using ProductCatalogue.Models;

namespace ProductCatalogue.Pages.Mens
{
    public class EditModel : PageModel
    {
        private readonly ProductCatalogue.Data.ShopContext _context;

        public EditModel(ProductCatalogue.Data.ShopContext context)
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
           ViewData["ProductID"] = new SelectList(_context.Products, "ID", "ID");
           ViewData["TypeID"] = new SelectList(_context.Types, "TypeID", "TypeID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Men).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenExists(Men.MenID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MenExists(int id)
        {
            return _context.Mens.Any(e => e.MenID == id);
        }
    }
}
