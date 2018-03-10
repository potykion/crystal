using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Crystal.Models;

namespace Crystal.Pages.HeatTabl
{
    public class EditModel : PageModel
    {
        private readonly Crystal.Models.CrystalContext _context;

        public EditModel(Crystal.Models.CrystalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HeatTablInvariant HeatTablInvariant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HeatTablInvariant = await _context.HeatTablInvariant
                .Include(h => h.BknumberNavigation)
                .Include(h => h.HeadClueNavigation).FirstOrDefaultAsync(m => m.Id == id);

            if (HeatTablInvariant == null)
            {
                return NotFound();
            }
           ViewData["Bknumber"] = new SelectList(_context.BibliogrInvariant, "Bknumber", "Bknumber");
           ViewData["HeadClue"] = new SelectList(_context.HeadTablInvariant, "HeadClue", "Help");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(HeatTablInvariant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HeatTablInvariantExists(HeatTablInvariant.Id))
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

        private bool HeatTablInvariantExists(int id)
        {
            return _context.HeatTablInvariant.Any(e => e.Id == id);
        }
    }
}
