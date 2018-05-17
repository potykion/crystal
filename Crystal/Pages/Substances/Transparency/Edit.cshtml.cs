using System.Linq;
using System.Threading.Tasks;
using Crystal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances.Transparency
{
    [Authorize(Policy = "AdminOnly")]
    public class EditModel : PageModel
    {
        private readonly CrystalContext _context;

        public EditModel(CrystalContext context)
        {
            _context = context;
        }

        [BindProperty] public Wavepure Wavepure { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Wavepure = await _context.Wavepure
                .FirstOrDefaultAsync(m => m.Id == id);

            var singCodes = await _context.SingTabl.Select(s => s.SingType).Distinct().ToListAsync();
            ViewData["SingCode"] = new SelectList(singCodes);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var WavepureToUpadte = await _context.Wavepure
                .FirstOrDefaultAsync(m => m.Id == id);

            await TryUpdateModelAsync(
                WavepureToUpadte,
                "Wavepure",
m => m.Leftwave ,m => m.Rightwave , m => m.Bknumber , m => m.SingCode             );

            await _context.SaveChangesAsync();

            return Page();
        }
    }
}