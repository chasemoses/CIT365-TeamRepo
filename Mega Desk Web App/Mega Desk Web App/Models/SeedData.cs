using Mega_Desk_Web_App.Data;
using Microsoft.EntityFrameworkCore;


namespace Mega_Desk_Web_App.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Mega_Desk_Web_AppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Mega_Desk_Web_AppContext>>()))
            {
                if (context == null || context.Quote == null)
                {
                    throw new ArgumentNullException("Null QuoteContext");
                }

                // Look for any Quotes.
                if (context.Quote.Any())
                {
                    return;   // DB has been seeded
                }

                //context.Quote.AddRange(
                //    new Quote
                //    {
                //        CustName = "Allan",
                //        Material = "Oak",
                //        Price = 200
                //    },

                //    new Quote
                //    {
                //        CustName = "Chase ",
                //        Material = "Laminate",
                //        Price = 100
                //    },

                //    new Quote
                //    {
                //        CustName = "Britany",
                //        Material = "Pine",
                //        Price = 50
                //    },

                //    new Quote
                //    {
                //        CustName = "Jillian",
                //        Material = "Rosewood",
                //        Price = 300
                //    }
                //);
                context.SaveChanges();
            }
        }
    }
}
