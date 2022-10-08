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
    public class SurfaceMaterials : SmartEnum<SurfaceMaterials, decimal>
    {
        public static readonly SurfaceMaterials Laminate = new SurfaceMaterials(nameof(Laminate), 100m);
        public static readonly SurfaceMaterials Oak = new SurfaceMaterials(nameof(Oak), 200m);
        public static readonly SurfaceMaterials Rosewood = new SurfaceMaterials(nameof(Rosewood), 300m);
        public static readonly SurfaceMaterials Veneer = new SurfaceMaterials(nameof(Veneer), 125m);
        public static readonly SurfaceMaterials Pine = new SurfaceMaterials(nameof(Pine), 50m);

        public SurfaceMaterials(string name, decimal value) : base(name, value)
        {
        }

    }

    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }

        [JsonConverter(typeof(SmartEnumNameConverter<SurfaceMaterials, decimal>))]
        public SurfaceMaterials SurfaceMaterials { get; set; }

        // Constructor
        public Desk(int width, int depth, int numberOfDrawers, SurfaceMaterials surfaceMaterials)
        {
            Width = width;
            Depth = depth;
            NumberOfDrawers = numberOfDrawers;
            SurfaceMaterials = surfaceMaterials;
        }

        // Default Constructor
        public Desk()
        {
        }

        const int MIN_WIDTH = 24;
        const int MAX_WIDTH = 96;
        const int MIN_DEPTH = 12;
        const int MAX_DEPTH = 48;

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
