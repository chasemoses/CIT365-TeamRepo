using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mega_Desk_Web_App.Data;
using Mega_Desk_Web_App.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mega_Desk_Web_App.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        private readonly Mega_Desk_Web_App.Data.Mega_Desk_Web_AppContext _context;

        public IndexModel(Mega_Desk_Web_App.Data.Mega_Desk_Web_AppContext context)
        {
            _context = context;
        }

        public IList<Quote> Quote { get; set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? Material { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? QuoteCustName { get; set; }
        public SelectList? CustName { get; set; }


        public string DateSort { get; set; }
        public string CustNameSort { get; set; }


        public async Task OnGetAsync(string sortQuote, string SearchString)
        {
            var quotes = from m in _context.Quote
                             select m;
            CustNameSort = String.IsNullOrEmpty(sortQuote) ? "Name" : "";
            DateSort = sortQuote == "Date" ? "date_desc" : "Date";

            if (!string.IsNullOrEmpty(SearchString))
            {
                quotes = quotes.Where(s => s.Material.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(QuoteCustName))
            {
                quotes = quotes.Where(s => s.CustName.Contains(QuoteCustName));
            }

            switch (sortQuote)
            {
                case "CustName":
                    quotes = quotes.OrderByDescending(s => s.CustName);
                    break;
                case "QuoteDate":
                    quotes = quotes.OrderByDescending(s => s.QuoteDate);
                    break;
                default:
                    quotes = quotes.OrderBy(s => s.CustName);
                    break;
            }

            Quote = await quotes.ToListAsync();
        }

    }
}
