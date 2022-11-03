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
    public class DetailsModel : PageModel
    {
        private readonly Mega_Desk_Web_App.Data.Mega_Desk_Web_AppContext _context;

        public DetailsModel(Mega_Desk_Web_App.Data.Mega_Desk_Web_AppContext context)
        {
            _context = context;
        }

      public Quote Quote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Quote == null)
            {
                return NotFound();
            }

            var quote = await _context.Quote.FirstOrDefaultAsync(m => m.ID == id);
            if (quote == null)
            {
                return NotFound();
            }
            else 
            {
                Quote = quote;
            }
            return Page();
        }
    }
}
