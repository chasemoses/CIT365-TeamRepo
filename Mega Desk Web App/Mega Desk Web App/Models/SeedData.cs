using Mega_Desk_Web_App.Data;
using Microsoft.EntityFrameworkCore;

namespace Mega_Desk_Web_App.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Mega_Desk_Web_AppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Mega_Desk_Web_AppContext>>()))
            {
                if (context == null || context.Quote == null)
                {
                    throw new ArgumentNullException("Null RazorPagesQuoteContext");
                }

                // Look for any Quotes.
                if (context.Quote.Any())
                {
                    return;   // DB has been seeded
                }

                context.Quote.AddRange(
                    new Quote
                    {
                        CustName = "Allan",
                        QuoteDate = DateTime.Parse("1989-2-12"),
                        Material = "Oak",
                        Price = 200
                    },

                    new Quote
                    {
                        CustName = "Chase ",
                        QuoteDate = DateTime.Parse("1984-3-13"),
                        Material = "Laminate",
                        Price = 100
                    },

                    new Quote
                    {
                        CustName = "Britany",
                        QuoteDate = DateTime.Parse("1986-2-23"),
                        Material = "Pine",
                        Price = 50
                    },

                    new Quote
                    {
                        CustName = "Jillian",
                        QuoteDate = DateTime.Parse("1959-4-15"),
                        Material = "Rosewood",
                        Price = 300
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
