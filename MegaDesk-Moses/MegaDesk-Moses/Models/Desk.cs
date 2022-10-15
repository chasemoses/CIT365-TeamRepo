using Ardalis.SmartEnum;
using Ardalis.SmartEnum.JsonNet;
using CSharpFunctionalExtensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MegaDesk_Moses.Models
{
    /// <summary>
    /// This is an enum, inheriting from SmartEnum by Ardalis (nuget package).
    /// Allows more control in circumnstances where you use the name, versus 
    /// obtaining the value.
    /// </summary>
    public class SurfaceMaterials : SmartEnum<SurfaceMaterials, decimal>
    {
        public static readonly SurfaceMaterials Laminate = new SurfaceMaterials(nameof(Laminate), 100m);
        public static readonly SurfaceMaterials Oak = new SurfaceMaterials(nameof(Oak), 200m);
        public static readonly SurfaceMaterials Rosewood = new SurfaceMaterials(nameof(Rosewood), 300m);
        public static readonly SurfaceMaterials Veneer = new SurfaceMaterials(nameof(Veneer), 125m);
        public static readonly SurfaceMaterials Pine = new SurfaceMaterials(nameof(Pine), 50m);

        /// <summary>
        /// Special Constructor used by Smart Enum
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public SurfaceMaterials(string name, decimal value) : base(name, value)
        {
        }

    }

    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }

        // This property is used to make sure the smartenum for SurfaceMaterials stores 
        // properly in the json file.
        [JsonConverter(typeof(SmartEnumNameConverter<SurfaceMaterials, decimal>))]
        public SurfaceMaterials SurfaceMaterials { get; set; }


        // Constant variables per instructions
        const int MIN_WIDTH = 24;
        const int MAX_WIDTH = 96;
        const int MIN_DEPTH = 12;
        const int MAX_DEPTH = 48;

        // Default Constructor
        public Desk()
        {
        }

        /// <summary>
        /// Calculation Methods for PriceModel to display to users in DisplayQuote.cs
        /// </summary>
        /// <returns></returns>
        public decimal CalculateAreaCost()
        {
            int deskArea = Width * Depth;

            if (deskArea < 1000)
            {
                // Area won't cost anything if under 1000
                return 0m;

            }

            // Remove everything up to 1000. Whatever 
            // remaining is the cost of the deskArea.
            deskArea -= 1000;

            decimal areaCost = Convert.ToDecimal(deskArea);
            return areaCost;
        }

        public decimal CalculateDrawerCost()
        {
            return Convert.ToDecimal(NumberOfDrawers * 50);
        }

        public decimal CalculateMaterialCost()
        {
            return SurfaceMaterials.Value;
        }


        /// <summary>
        /// Encapsulation Methods that are called from DeskQuote to update Desk's properties.
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        internal Result<SurfaceMaterials> UpdateMaterial(SurfaceMaterials material)
        {
            // Do validation here
            SurfaceMaterials = material;

            return Result.Success(material);
        }

        internal Result UpdateWidth(int value)
        {
            // Validate
            if (value < MIN_WIDTH || value > MAX_WIDTH)
            {
                return Result.Failure("Width must be within range! ");
            }

            Width = value;

            return Result.Success();

        }

        internal Result UpdateDepth(int value)
        {
            // Validate
            if (value < MIN_DEPTH || value > MAX_DEPTH)
            {
                return Result.Failure("Depth must be within range! ");
            }

            Depth = value;

            return Result.Success();
        }

        internal Result UpdateDrawer(int value)
        {
            // Validate
            NumberOfDrawers = value;

            return Result.Success();
        }

        /// <summary>
        /// Helper class to make sure the width and depth is valid.
        /// </summary>
        /// <returns></returns>
        internal bool IsValid()
        {
            if (Width < MIN_WIDTH || Width > MAX_WIDTH)
            {
                return false;
            }
            if (Depth < MIN_DEPTH || Depth > MAX_DEPTH)
            {
                return false;
            }

            return true;
        }

        internal int GetArea() => Width * Depth;

    }
}
