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

        [BindProperty] public HeadTablLanguage HeadTablLanguage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HeadTablLanguage = await _context.HeadTablLanguage
                .Include(h => h.HeadTabl)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (HeadTablLanguage == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            var headTablToUpdate = await _context.HeadTablLanguage
                .Include(h => h.HeadTabl)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (await TryUpdateModelAsync<HeadTablLanguage>(
                headTablToUpdate,
                "HeadTablLanguage",
                i => i.HeadTabl, i => i.LanguageId, i => i.Expert, i => i.System
            ))
            {
                await _context.SaveChangesAsync();
            }


            return RedirectToPage("./Index");
        }

        private bool HeadTablLanguageExists(int id)
        {
            return _context.HeadTablLanguage.Any(e => e.Id == id);
        }
    }
}