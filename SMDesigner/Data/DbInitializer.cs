using SMDesigner.Models;
using System;
using System.Diagnostics;
using System.Linq;

namespace SMDesigner.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ProgramContext context)
        {
            context.Database.EnsureCreated();

           
            if (context.SacramentPrograms.Any())
            {
                return;   // DB has been seeded
            }

            var sacramentprograms = new SacramentProgram[]
            {
            new SacramentProgram{ConductorL="Guss Rat", OpenSong="The Morning Breaks", ProgramDate=DateTime.Parse("2005-09-01"), OpenPrayer="Jasper Dog", SacramentSong="Child of God", Speakers={"Chloe Cat", "Oreo Dog" }, Subject="Jesus", IntermedNum="Piano", CloseSong="Choose the Right", ClosePrayer="Luna Dog"},
            new SacramentProgram{ConductorL="Ragnar Lizard", OpenSong="Praise to the Man", ProgramDate=DateTime.Parse("2005-09-01"), OpenPrayer="Rambo Dog", SacramentSong="I Love to See the Temple", Speakers={"Ringo Dog", "Sasha Cat" }, Subject="Temples", IntermedNum="", CloseSong="Come Thou Font", ClosePrayer="Vanessa Cat"},
            new SacramentProgram{ConductorL="Lilly Dog", OpenSong="Lead, Kindly Light", ProgramDate=DateTime.Parse("2005-09-01"), OpenPrayer="Austin Dog", SacramentSong="The Spirit of God", Speakers={"Sophie Rat", "Perry Platapus" }, Subject="Prophets", IntermedNum="Violin", CloseSong="Love One Another", ClosePrayer="Harry Frog"},

            };
            foreach (SacramentProgram s in sacramentprograms)
            {
                context.SacramentPrograms.Add(s);
            }
            context.SaveChanges();

        }
    }
}