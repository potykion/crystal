using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Crystal.Models;

namespace Crystal.Pages.DensTabl
{
    public class EditModel : PageModel
    {
        private readonly Crystal.Models.CrystalContext _context;

        public EditModel(Crystal.Models.CrystalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DensTablLanguage DensTablLanguage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DensTablLanguage = await _context.DensTablLanguage
                .Include(d => d.BknumberNavigation)
                .Include(d => d.HeadClueNavigation)
                .Include(d => d.SingTabl).FirstOrDefaultAsync(m => m.Id == id);

            if (DensTablLanguage == null)
            {
                return NotFound();
            }
           ViewData["Bknumber"] = new SelectList(_context.BibliogrInvariant, "Bknumber", "Bknumber");
           ViewData["HeadClue"] = new SelectList(_context.HeadTablInvariant, "HeadClue", "Help");
           ViewData["HeadClue"] = new SelectList(_context.SingTabl, "HeadClue", "SingType");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DensTablLanguage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DensTablLanguageExists(DensTablLanguage.Id))
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

        private bool DensTablLanguageExists(int id)
        {
            return _context.DensTablLanguage.Any(e => e.Id == id);
        }
    }
}
