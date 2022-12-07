using System;
using System.Collections.Generic;

namespace SMDesigner.Models
{
    public class SacramentProgram
    {
        public int ID { get; set; }
        public string ConductorL { get; set; }
        public string OpenSong { get; set; }
        public DateTime ProgramDate { get; set; }
        public string OpenPrayer { get; set; }
        public string SacramentSong { get; set; }
        public string SpeakerFullName { get; set; }
        public string Subject { get; set; }
        public string IntermedNum { get; set; }
        public string CloseSong { get; set; }
        public string ClosePrayer { get; set; }

    }
}
