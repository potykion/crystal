using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Crystal.Models;

namespace Crystal.Pages.HeadTabl
{
    public class CreateModel : PageModel
    {
        private readonly Crystal.Models.CrystalContext _context;

        public CreateModel(Crystal.Models.CrystalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["HeadTablId"] = new SelectList(_context.HeadTablInvariant, "HeadClue", "Help");
            return Page();
        }

        [BindProperty]
        public HeadTablLanguage HeadTablLanguage { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.HeadTablLanguage.Add(HeadTablLanguage);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}