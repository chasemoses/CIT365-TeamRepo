

using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Mega_Desk_Web_App.Models
{
    public enum ProductionTime
    {
        Normal,

        [Display(Name = "3 Days")]
        ThreeDay = 3,

        [Display(Name = "5 Days")]
        FiveDay = 5,

        [Display(Name = "7 Days")]
        SevenDay = 7

    }
}
