using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Crystal.Models;

namespace Crystal.Pages.HeadTabl
{
    public class EditModel : PageModel
    {
        private readonly Crystal.Models.CrystalContext _context;

        public EditModel(Crystal.Models.CrystalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HeadTablInvariant HeadTablInvariant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HeadTablInvariant = await _context.HeadTablInvariant.FirstOrDefaultAsync(m => m.HeadClue == id);

            if (HeadTablInvariant == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(HeadTablInvariant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HeadTablInvariantExists(HeadTablInvariant.HeadClue))
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

        private bool HeadTablInvariantExists(int id)
        {
            return _context.HeadTablInvariant.Any(e => e.HeadClue == id);
        }
    }
}
