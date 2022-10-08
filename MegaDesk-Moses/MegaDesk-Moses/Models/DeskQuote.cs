using Ardalis.SmartEnum.JsonNet;
using CSharpFunctionalExtensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Moses.Models
{
    public class DeskQuote
    {
        public string Name { get; set; }
        public Desk Desk { get; set; }

        [JsonConverter(typeof(SmartEnumNameConverter<RushDay, int>))]
        public RushDay RushOrderDay { get; set; }
        public DateTime QuoteDate { get; set; }
        public decimal TotalPrice => GetPricing().TotalCost;

        public bool IsComplete { get; set; }


        public DeskQuote(Desk desk)
        {
            Desk = desk;
            QuoteDate = DateTime.Now;
            IsComplete = false;
        }

        public Result<SurfaceMaterials> UpdateMaterial(SurfaceMaterials material)
        {
            return Desk.UpdateMaterial(material);
        }

        public static DeskQuote CreateEmpty()
        {
            return new DeskQuote(new Desk());
        }

        internal Result UpdateWidth(int value)
        {
            return Desk.UpdateWidth(value);
        }

        internal Result UpdateDepth(int value)
        {
            return Desk.UpdateDepth(value);
        }

        internal Result UpdateDrawer(int value)
        {
            return Desk.UpdateDrawer(value);
        }

        internal Result UpdateRushDay(RushDay rushDay)
        {
            RushOrderDay = rushDay;
            return Result.Success();
        }

        internal bool IsValid()
        {
            if (String.IsNullOrEmpty(Name))
            {
                return false;
            }

            if (!Desk.IsValid())
            {
                return false;
            }

            return true;
        }

        public PriceModel GetPricing()
        {
            // Calculate Area cost if there is one
            decimal areaCost = Desk.CalculateAreaCost();

            // Calculate Drawer Cost
            decimal drawerCost = Desk.CalculateDrawerCost();

            // Calculate Desk Material Cost
            decimal materialCost = Desk.CalculateMaterialCost();

            // Calculate Expedited Cost based on area
            decimal rushCost = CalculateRushDayCost(RushOrderDay, Desk.GetArea());

            PriceModel priceModel = new PriceModel(areaCost, drawerCost, materialCost,
                                                   rushCost);

            return priceModel;

        }
        private decimal CalculateRushDayCost(RushDay rushDay, int deskArea)
        {
            switch(rushDay.Value)
            {
                case 3:
                    if (deskArea < 1000)
                        return 60m;

                    else if (deskArea >= 1000 && deskArea <= 2000)
                        return 70m;

                    else if (deskArea > 2000)
                        return 80m;
                    break;

                case 5:
                    if (deskArea < 1000)
                        return 40m;

                    else if (deskArea >= 1000 && deskArea <= 2000)
                        return 50m;

                    else if (deskArea > 2000)
                        return 60m;
                    break;

                case 7:
                    if (deskArea < 1000)
                        return 30m;

                    else if (deskArea >= 1000 && deskArea <= 2000)
                        return 35m;

                    else if (deskArea > 2000)
                        return 40m;
                    break;
            }

            return 0m;


        }
    }
}
