using System.Linq;
using System.Threading.Tasks;
using Crystal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances.Composition
{
    [Authorize(Policy = "AdminOnly")]
    public class EditModel : PageModel
    {
        private readonly CrystalContext _context;

        public EditModel(CrystalContext context)
        {
            _context = context;
        }

        [BindProperty] public SistTabl SistTabl { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            SistTabl = await _context.SistTabl
                .FirstOrDefaultAsync(m => m.Id == id);


            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var SistTablToUpadte = await _context.SistTabl
                .FirstOrDefaultAsync(m => m.Id == id);

            await TryUpdateModelAsync(
                SistTablToUpadte,
                "SistTabl",
m => m.ElemNumb ,m => m.MinValue ,m => m.MaxValue             );

            await _context.SaveChangesAsync();

            return Page();
        }
    }
}