using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Moses.Models
{
    /// <summary>
    /// DisplayQuote.cs will be using this class instead of DeskQuote when
    /// determining the prices that will be showed to the user in DisplayQuote.cs
    /// </summary>
    public class PriceModel
    {
        public decimal AreaCost { get; set; }
        public decimal DrawerCost { get; set; }
        public decimal MaterialCost { get; set; }
        public decimal ExpediteCost { get; set; }
        public decimal TotalCost { get; set; }

        private const decimal BASE_PRICE = 200m;

        public PriceModel(DeskQuote deskQuote, Desk desk)
        {
            AreaCost = desk.CalculateAreaCost();
            DrawerCost = desk.CalculateDrawerCost();
            MaterialCost = desk.CalculateMaterialCost();
            ExpediteCost = deskQuote.GetRushOrder(deskQuote.RushOrderDay, desk.GetArea());

            TotalCost = AreaCost +
                DrawerCost +
                MaterialCost + ExpediteCost + BASE_PRICE;
        }

    }
}
