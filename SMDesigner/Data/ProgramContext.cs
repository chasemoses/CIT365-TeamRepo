using SMDesigner.Models;
using Microsoft.EntityFrameworkCore;


namespace SMDesigner.Data
{
    public class ProgramContext : DbContext
    {
        public ProgramContext(DbContextOptions<ProgramContext> options) : base(options)
        {
        }

        public DbSet<SacramentProgram> SacramentPrograms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SacramentProgram>().ToTable("SacramentProgram");
        }
    }
}