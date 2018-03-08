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
    public class DetailsModel : PageModel
    {
        private readonly Crystal.Models.CrystalContext _context;

        public DetailsModel(Crystal.Models.CrystalContext context)
        {
            _context = context;
        }

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
    }
}
