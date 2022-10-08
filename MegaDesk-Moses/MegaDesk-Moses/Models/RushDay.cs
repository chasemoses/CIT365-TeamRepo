using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Moses.Models
{
    public class RushDay : SmartEnum<RushDay>
    {
        public static readonly RushDay Normal = new RushDay(nameof(Normal), 0, "Normal");
        public static readonly RushDay ThreeDay = new RushDay(nameof(ThreeDay), 3, "3 Day");
        public static readonly RushDay FiveDay = new RushDay(nameof(FiveDay), 5, "5 Day");
        public static readonly RushDay SevenDay = new RushDay(nameof(SevenDay), 7, "7 Day");
        public string DisplayName { get; set; }

        public RushDay(string name, int value, string displayName) : base(name, value)
        {
            DisplayName = displayName;
        }
    }
}
