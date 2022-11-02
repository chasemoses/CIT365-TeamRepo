using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mega_Desk_Web_App.Data;
using Mega_Desk_Web_App.Models;

namespace Mega_Desk_Web_App.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        private readonly Mega_Desk_Web_App.Data.Mega_Desk_Web_AppContext _context;

        public IndexModel(Mega_Desk_Web_App.Data.Mega_Desk_Web_AppContext context)
        {
            _context = context;
        }

        public IList<Quote> Quote { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Quote != null)
            {
                Quote = await _context.Quote.ToListAsync();
            }
        }
    }
}
