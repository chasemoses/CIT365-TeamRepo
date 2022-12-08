using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SMDesigner.Models
{
    public class SacramentProgram
    {
        public int ID { get; set; }
        [Display(Name = "Conductor")]
        public string ConductorL { get; set; }
        [Display(Name = "Opening Song")]        
        public string OpenSong { get; set; }
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime ProgramDate { get; set; }
        [Display(Name = "Opening Prayer")]
        public string OpenPrayer { get; set; }
        [Display(Name = "Sacrament Song")]
        public string SacramentSong { get; set; }
        [Display(Name = "Speaker")]
        public string SpeakerFullName { get; set; }
        [Display(Name = "Subject")]
        public string Subject { get; set; }
        [Display(Name = "Intermediate Number")]
        public string IntermedNum { get; set; }
        [Display(Name = "Closing Song")]
        public string CloseSong { get; set; }
        [Display(Name = "Closing Prayer")]
        public string ClosePrayer { get; set; }

    }
}
