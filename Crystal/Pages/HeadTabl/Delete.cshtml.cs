using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crystal.Models;

namespace Crystal.Pages.HeadTabl
{
    public class DeleteModel : PageModel
    {
        private readonly Crystal.Models.CrystalContext _context;

        public DeleteModel(Crystal.Models.CrystalContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HeadTablInvariant = await _context.HeadTablInvariant.FindAsync(id);

            if (HeadTablInvariant != null)
            {
                _context.HeadTablInvariant.Remove(HeadTablInvariant);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
