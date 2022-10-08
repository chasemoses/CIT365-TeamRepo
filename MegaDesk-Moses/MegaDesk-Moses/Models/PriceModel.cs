using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Moses.Models
{
    public class PriceModel
    {
        public decimal AreaCost { get; set; }
        public decimal DrawerCost { get; set; }
        public decimal MaterialCost { get; set; }
        public decimal ExpediteCost { get; set; }
        public decimal TotalCost { get; set; }

        private const decimal BASE_PRICE = 200m;

        public PriceModel(decimal areaCost, decimal drawerCost, 
            decimal materialCost, decimal expediteCost)
        {
            AreaCost = areaCost;
            DrawerCost = drawerCost;
            MaterialCost = materialCost;
            ExpediteCost = expediteCost;

            TotalCost = AreaCost + DrawerCost + MaterialCost + ExpediteCost + BASE_PRICE;
        }

    }
}
