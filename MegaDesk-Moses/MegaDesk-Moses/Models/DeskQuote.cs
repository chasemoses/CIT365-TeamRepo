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



        /// <summary>
        /// Used if the DeskQuote is found to be null when trying to use it. 
        /// Keeps from the program crashing.
        /// </summary>
        /// <returns></returns>
        public static DeskQuote CreateEmpty()
        {
            return new DeskQuote(new Desk());
        }

        /// <summary>
        /// DeskQuote receives requests to update the Desk object's values, 
        /// including validation. The Methods below ask the desk to "update itself" 
        /// (DeskQuote aka: Root Aggregate)
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        public Result<SurfaceMaterials> UpdateMaterial(SurfaceMaterials material)
        {
            return Desk.UpdateMaterial(material);
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

        /// <summary>
        /// This method is responsible for creating a PriceModel that the DisplayQuote.cs form will
        /// use to display the pricing to the user when the quote is completed.
        /// </summary>
        /// <returns></returns>
        public PriceModel GetPricing()
        {

            // Pass in DeskQuote and Desk objects to a price model to calculate
            // Prices that will be displayed to the user.
            return new PriceModel(this, Desk);


        }

        /// <summary>
        /// This method is responsible for reading values from the rushOrderPrice.txt file 
        /// and storing it in a 2d array, and finding the price based on rush day and
        /// square area.
        /// </summary>
        /// <param name="rushDay"></param>
        /// <param name="deskArea"></param>
        /// <returns></returns>
        public decimal GetRushOrder(RushDay rushDay, int deskArea)
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

                // Populate 2d array from 1d array
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
                int row = FindRushOrderIndex(rushDay);
                int column = FindRushOrderIndex(deskArea);

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

        /// <summary>
        /// This method is responsible for returning the indexes that the 2d
        /// array will use to get the specified Rush Order Cost based on
        /// Square Area and Rush Day value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private int FindRushOrderIndex(int value)
        {
            // RUSH ORDER PRICE TABLE USING 2D ARRAY

            //              < 1k  | 1k to 2k | > 2k   (Square Inches)
            //  Rush           0        1        2  
            //
            //   3 Day   0    $60       $70     $80
            //   5 Day   1    $40       $50     $60
            //   7 Day   2    $30       $35     $40

            // If Square Area is a minimum of 288 (24 * 12) and is less than 1000
            // Return Index 0 for Column.
            // If Rush Order is 3 Day, return 0 for row.
            if (value >= 288 && value < 1000 || value == 3)
                return 0;

            // Return index 1 if square area is between 1k and 2k or if Rush Day
            // is 5 Day
            else if (value >= 1000 && value <= 2000 || value == 5)
                return 1;

            // Return index of 2 if the square area is bigger than 2k, or if the
            // Rush day is 7 Days.
            else if (value > 2000 || value == 7)
                return 2;

            // If we hit this point, then the rush day is normal.
            return -1;
        }
    }
}
