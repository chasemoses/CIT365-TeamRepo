using System.ComponentModel.DataAnnotations;

namespace Mega_Desk_Web_App.Models
{
    //Comment made by allan for testing purposes.
    public class Quote
    {
        /**public enum desktopMaterial
        {
            Oak = 200,
            Laminate = 1000,
            Pine = 50,
            Rosewood = 300,
            Veneer = 125
        }
        */

        public const int MINW = 24;
        public const int MAXW = 96;
        public const int MIND = 12;
        public const int MAXD = 48;
        public const int MINDCOUNT = 1;
        public const int MAXDCOUNT = 7;


        public int ID { get; set; }

        [Display(Name = "Name")]
        [RegularExpression(@"^[a-zA-Z\s]*$")]
        [StringLength(50, MinimumLength = 5)]
        [Required]
        public string CustName { get; set; } = string.Empty;

        [Display(Name = "Date Added")]
        [DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }

        [Display(Name = "Desk Width")]
        [Range(MINW, MAXW)]
        [Required]
        public int Width { get; set; }

        [Display(Name = "Desk Depth")]
        [Range(MIND, MAXD)]
        [Required]
        public int Depth { get; set; }

        [Display(Name = "Number of Drawers")]
        [Range(MINDCOUNT, MAXDCOUNT)]
        [Required]
        public int Drawers { get; set; }

        [Display(Name = "Desk Material")]
        [Required]
        public string Material { get; set; } = string.Empty;

        [Required]
        public int Production { get; set; }

        [Required]
        public decimal Price { get; set; }


    }
}
