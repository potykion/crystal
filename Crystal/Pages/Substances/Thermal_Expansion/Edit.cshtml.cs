using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Crystal.Models;

namespace Crystal.Pages.Substances.Thermal_Expansion
{
    public class EditModel : PageModel
    {
        private readonly Crystal.Models.CrystalContext _context;

        public EditModel(Crystal.Models.CrystalContext context)
        {
            _context = context;
        }

        [BindProperty] public HeatExpnLanguage HeatExpnLanguage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HeatExpnLanguage = await _context.HeatExpnLanguage
                .Include(h => h.HeatExpn)
                .Include(h => h.HeatExpn.BknumberNavigation)
                .Include(h => h.HeatExpn.SingTabl)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (HeatExpnLanguage == null)
            {
                return NotFound();
            }

            ViewData["Bknumber"] = new SelectList(_context.BibliogrInvariant, "Bknumber", "Bknumber");
            ViewData["HeadClue"] = new SelectList(_context.SingTabl, "HeadClue", "SingType");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(HeatExpnLanguage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HeatExpnLanguageExists(HeatExpnLanguage.Id))
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

        private bool HeatExpnLanguageExists(int id)
        {
            return _context.HeatExpnLanguage.Any(e => e.Id == id);
        }
    }
}