using Ardalis.SmartEnum.JsonNet;
using CSharpFunctionalExtensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MegaDesk_Moses.Properties;

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

        const string FILENAME = "./rushOrderPrices.txt";


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
            decimal rushCost = GetRushOrder(RushOrderDay, Desk.GetArea());

            PriceModel priceModel = new PriceModel(areaCost, drawerCost, materialCost,
                                                   rushCost);

            return priceModel;

        }
        private decimal GetRushOrder(RushDay rushDay, int deskArea)
        {
            // Create multi-dimensional array
            decimal [,] rushOrderAmounts = new decimal [3, 3];

            // If the file doesn't exist, don't continue.
            if (!File.Exists(FILENAME))
            {
                Console.WriteLine("File does not exist.");
                return -1;
            }

            try
            {
                // read values into a temp 1d array, then use nested for loop
                // to populate the 2d array.
                var tempArray = File.ReadAllLines(FILENAME);

                int index = 0;

                for (int i = 0; i <= 2; i++)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        rushOrderAmounts[i, j] = decimal.Parse(tempArray[index]);
                        index++;
                    }
                }

                // Get the row and column of what we need to get the value
                // From the 2d array.
                int row = FindRushOrderCost(rushDay);
                int column = FindRushOrderCost(deskArea);

                // Return final value as long as Rush Day is not normal 
                if (row != -1)
                    return rushOrderAmounts[row, column];


            }
            catch (Exception e)
            {
                Console.WriteLine($"Message: {e}");
            }

            // If we have gotten this far, then the rush day should be normal.
            return 0m;
        }

        private int FindRushOrderCost(int value)
        {
            if (value >= 288 && value < 1000 || value == 3)
                return 0;

            else if (value >= 1000 && value <= 2000 || value == 5)
                return 1;

            else if (value > 2000 || value == 7)
                return 2;

            // If we hit this point, then the rush day is normal.
            return -1;
        }
    }
}
