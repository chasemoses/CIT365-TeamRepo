using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mega_Desk_Web_App.Models;

namespace Mega_Desk_Web_App.Data
{
    public class Mega_Desk_Web_AppContext : DbContext
    {
        public Mega_Desk_Web_AppContext (DbContextOptions<Mega_Desk_Web_AppContext> options)
            : base(options)
        {
        }

        public DbSet<Mega_Desk_Web_App.Models.Quote> Quote { get; set; } = default!;
    }
}
