using System.Threading.Tasks;
using System.Linq;
using Crystal.Models;
using Crystal.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances.Lattice
{
    [Authorize(Policy = "AdminOnly")]
    public class CreateModel : PageModel
    {
        private readonly CrystalContext _context;
        private readonly ContextUtils _contextUtils;
        private readonly UrlBuilder _urlBuilder = new UrlBuilder();

        public CreateModel(CrystalContext context)
        {
            _context = context;
            _contextUtils = new ContextUtils(context);
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var singCodes = await _context.SingTabl.Select(s => s.SingType).Distinct().ToListAsync();
            ViewData["SingCode"] = new SelectList(singCodes);

            return Page();
        }

        [BindProperty] public ElemTablNewLanguage ElemTablNewLanguage { get; set; }

        public async Task<IActionResult> OnPostAsync(string systemUrl)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ElemTablNewLanguage.ElemTablNew.HeadClue = _contextUtils.GetHeadClueBySystemUrl(systemUrl);
            ElemTablNewLanguage.LanguageId = this.GetLanguageId();

            _context.ElemTablNewLanguage.Add(ElemTablNewLanguage);

            await _context.SaveChangesAsync();

            var url = _urlBuilder.BuildPropertyLink(
                this.GetLanguage(),
                "Lattice",
                system: systemUrl
            );
            return Redirect(url);

        }
    }
}