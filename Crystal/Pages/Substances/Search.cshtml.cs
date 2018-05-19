using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crystal.Models;
using Crystal.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Server.Kestrel.Transport.Libuv.Internal.Networking;
using Microsoft.EntityFrameworkCore;

namespace Crystal.Pages.Substances
{
    public class SearchPageModel : PageModel
    {
        private readonly CrystalContext _context;
        private SearchRequestProcessor _searchRequestProcessor;

        public SearchPageModel(CrystalContext context)
        {
            _context = context;
            _searchRequestProcessor = new SearchRequestProcessor(context);
        }

        public IList<HeadTablLanguage> HeadTabl { get; set; }
        [BindProperty] public SearchRequest SearchRequest { get; set; }

        public async Task OnGetAsync()
        {
            HeadTabl = new List<HeadTablLanguage>();
        }

        public async Task OnPostAsync()
        {
            var matchedHeadClues = await _searchRequestProcessor.Process(SearchRequest);

            var matchedHeadTabl = _context.HeadTablLanguage
                .Include(h => h.HeadTabl)
                .Where(h => h.LanguageId == this.GetLanguageId())
                .Where(h => matchedHeadClues.Contains(h.HeadTablId));

            HeadTabl = await matchedHeadTabl.ToListAsync();
        }
    }
}