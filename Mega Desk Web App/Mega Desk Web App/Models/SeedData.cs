using Mega_Desk_Web_App.Data;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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

                context.Quote.AddRange(
                    new Quote
                    {
                        CustName = "Allan",
                        QuoteDate = DateTime.Parse("10/29/2022 11:30 AM"),
                        Width = 12,
                        Depth = 32,
                        Drawers = 4,
                        Material = MaterialType.Oak,
                        Production = ProductionTime.Normal,
                        Price = 600m
                    },

                    new Quote
                    {
                        CustName = "Chase ",
                        QuoteDate = DateTime.Parse("11/1/2022 3:45 PM"),
                        Width = 12,
                        Depth = 24,
                        Drawers = 2,
                        Material = MaterialType.Rosewood,
                        Production = ProductionTime.ThreeDay,
                        Price = 660m
                    },

                    new Quote
                    {
                        CustName = "Britany",
                        QuoteDate = DateTime.Parse("11/4/2022 6:30 PM"),
                        Width = 16,
                        Depth = 20,
                        Drawers = 1,
                        Material = MaterialType.Pine,
                        Production = ProductionTime.FiveDay,
                        Price = 340m
                    },

                    new Quote
                    {
                        CustName = "Jillian",
                        QuoteDate = DateTime.Parse("11/5/2022 2:00 PM"),
                        Width = 12,
                        Depth = 40,
                        Drawers = 7,
                        Material = MaterialType.Veneer,
                        Production = ProductionTime.SevenDay,
                        Price = 705m
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
