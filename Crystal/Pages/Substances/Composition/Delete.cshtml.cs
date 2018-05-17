using System.Threading.Tasks;
using Crystal.Models;
using Crystal.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances.Composition
{
    [Authorize(Policy = "AdminOnly")]
    public class DeleteModel : PageModel
    {
        private readonly CrystalContext _context;
        private readonly UrlBuilder _urlBuilder = new UrlBuilder();
        private readonly ContextUtils _contextUtils;

        public DeleteModel(CrystalContext context)
        {
            _context = context;
            _contextUtils = new ContextUtils(context);
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
            SistTabl = await _context.SistTabl
                .FirstOrDefaultAsync(m => m.Id == id);

            _context.SistTabl.Remove(SistTabl);


            await _context.SaveChangesAsync();

            var url = _urlBuilder.BuildPropertyLink(
                this.GetLanguage(),
                "Composition",
                system: _contextUtils.GetSystemUrlByHeadClue(SistTabl.HeadClue)

            );
            return Redirect(url);

        }
    }
}