using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace SMDesigner.Models
{
    public class SacramentProgram
    {

        
        public int ID { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$")]
        [Display(Name = "Conductor")]
        [StringLength(30, MinimumLength =5)]
        [Required]
        public string ConductorL { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$")]
        [Display(Name = "Opening Song")]
        [StringLength(45, MinimumLength = 5)]
        [Required]
        public string OpenSong { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime ProgramDate { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$")]
        [Display(Name = "Opening Prayer")]
        [StringLength(30, MinimumLength = 5)]
        [Required]
        public string OpenPrayer { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$")]
        [Display(Name = "Sacrament Song")]
        [StringLength(45, MinimumLength = 5)]
        [Required]
        public string SacramentSong { get; set; }

        // Custom Validator since regular regex expressions do not work on lists.
        [Display(Name = "Speakers")]
        [Required, NoNumberInListString]
        public List<string> Speakers { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$")]
        [Display(Name = "Subject")]
        [StringLength(30, MinimumLength = 4)]
        [Required]
        public string Subject { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$")]
        [Display(Name = "Intermediate Number")]
        [StringLength(45, MinimumLength = 5)]
        public string IntermedNum { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$")]
        [Display(Name = "Closing Song")]
        [StringLength(45, MinimumLength = 5)]
        [Required]
        public string CloseSong { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$")]
        [Display(Name = "Closing Prayer")]
        [StringLength(30, MinimumLength = 5)]
        [Required]
        public string ClosePrayer { get; set; }

        public SacramentProgram()
        {
            Speakers = new();
        }

    }
}
