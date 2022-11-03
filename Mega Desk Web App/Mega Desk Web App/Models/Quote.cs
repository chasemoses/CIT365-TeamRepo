using System.ComponentModel.DataAnnotations;

namespace Mega_Desk_Web_App.Models
{
    //Comment made by allan for testing purposes.
    public class Quote
    {
        public int ID { get; set; }
        public string CustName { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }

        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        public string Material { get; set; } = string.Empty;
        public int Production { get; set; }
        public decimal Price { get; set; }
    }
}
