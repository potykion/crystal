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
        public HeadTablLanguage HeadTablLanguage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HeadTablLanguage = await _context.HeadTablLanguage
                .Include(h => h.HeadTabl).FirstOrDefaultAsync(m => m.Id == id);

            if (HeadTablLanguage == null)
            {
                return NotFound();
            }
           ViewData["HeadTablId"] = new SelectList(_context.HeadTablInvariant, "HeadClue", "Help");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(HeadTablLanguage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HeadTablLanguageExists(HeadTablLanguage.Id))
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

        private bool HeadTablLanguageExists(int id)
        {
            return _context.HeadTablLanguage.Any(e => e.Id == id);
        }
    }
}
