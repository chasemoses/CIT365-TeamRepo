using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mega_Desk_Web_App.Data;
using Mega_Desk_Web_App.Models;

namespace Mega_Desk_Web_App.Pages.Quotes
{
    public class EditModel : PageModel
    {
        private readonly Mega_Desk_Web_App.Data.Mega_Desk_Web_AppContext _context;

        public EditModel(Mega_Desk_Web_App.Data.Mega_Desk_Web_AppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Quote Quote { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Quote == null)
            {
                return NotFound();
            }

            var quote =  await _context.Quote.FirstOrDefaultAsync(m => m.ID == id);
            if (quote == null)
            {
                return NotFound();
            }
            Quote = quote;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Quote).State = EntityState.Modified;

            try
            {
                Quote.CalculateTotalPrice();
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuoteExists(Quote.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool QuoteExists(int id)
        {
          return _context.Quote.Any(e => e.ID == id);
        }
    }
}
