using System.Threading.Tasks;
using Crystal.Models;
using Crystal.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances.Transparency
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

        [BindProperty] public Wavepure Wavepure { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Wavepure = await _context.Wavepure
                .FirstOrDefaultAsync(m => m.Id == id);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            Wavepure = await _context.Wavepure
                .FirstOrDefaultAsync(m => m.Id == id);

            _context.Wavepure.Remove(Wavepure);


            await _context.SaveChangesAsync();

            var url = _urlBuilder.BuildPropertyLink(
                this.GetLanguage(),
                "Transparency",
                system: _contextUtils.GetSystemUrlByHeadClue(Wavepure.HeadClue)

            );
            return Redirect(url);

        }
    }
}