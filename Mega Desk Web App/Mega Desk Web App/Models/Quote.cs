using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


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

        public const int BASE_PRICE = 200;


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
        public MaterialType Material { get; set; }

        [Display(Name = "Production Time")]
        [Required]
        public ProductionTime Production { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Price { get; set; }


        // Inside class use only!
        private int Area => Width * Depth;


        public void CalculateTotalPrice()
        {
            // Set date
            QuoteDate = DateTime.Now;

            // Calculate price
            Price = BASE_PRICE +
                    CalculateAreaCost() +
                    CalculateMaterialCost() +
                    CalculateDrawerCost() +
                    CalculateProductionCost();
        }

        private decimal CalculateAreaCost()
        {
            // If area is less than 1000, just return 0.
            if (Area <= 1000)
            {
                return 0m;
            }

            // If it is over 1000, subtract area by 1000 and return that amount.

            int areaCost = Area - 1000;

            return areaCost;
        }

        private decimal CalculateMaterialCost()
        {
            return (decimal)Material;
        }

        private decimal CalculateDrawerCost()
        {
            if (Drawers == 0)
                return 0m; // Don't charge for drawers if they don't have any!

            decimal drawerCost = Drawers * 50;

            return drawerCost;
        }

        private decimal CalculateProductionCost()
        {

            switch (Production)
            {
                case ProductionTime.ThreeDay:
                    if (Area < 1000)
                        return 60m;
                    else if (Area >= 1000 && Area <= 2000)
                        return 70m;
                    else if (Area > 2000)
                        return 80m;
                    break;

                case ProductionTime.FiveDay:
                    if (Area < 1000)
                        return 40m;
                    else if (Area >= 1000 && Area <= 2000)
                        return 50m;
                    else if (Area > 2000)
                        return 60m;
                    break;

                case ProductionTime.SevenDay:
                    if (Area < 1000)
                        return 30m;
                    else if (Area >= 1000 && Area <= 2000)
                        return 35m;
                    else if (Area > 2000)
                        return 40m;
                    break;

            }

            // If we have made it here, then return 0m, because it is just normal shipping.
            return 0m;
        }

    }
}
