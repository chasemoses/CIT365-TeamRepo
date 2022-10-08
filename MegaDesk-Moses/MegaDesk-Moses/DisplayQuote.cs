using MegaDesk_Moses.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Moses
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote _deskQuote;

        public DisplayQuote(DeskQuote deskQuote)
        {
            _deskQuote = deskQuote;

            InitializeComponent();

            // Set Date
            LabelDate.Text = _deskQuote.QuoteDate.ToShortDateString();


            // Set all Boxes to whatever values were set previously.
            TBName.Text = _deskQuote.Name;
            TBWidth.Text = _deskQuote.Desk.Width.ToString();
            TBDepth.Text = _deskQuote.Desk.Depth.ToString();
            CBNumDrawers.Text = _deskQuote.Desk.NumberOfDrawers.ToString();
            CBMaterials.Text = _deskQuote.Desk.SurfaceMaterials.ToString();
            CBRushDay.Text = _deskQuote.RushOrderDay.DisplayName;


            // Set all Cost labels to whatever cost values.
            var priceModel = _deskQuote.GetPricing();
            LabelAreaCost.Text = "$ " + priceModel.AreaCost.ToString();
            LabelDrawerCost.Text = "$ " + priceModel.DrawerCost.ToString();
            LabelMaterialCost.Text = "$ " + priceModel.MaterialCost.ToString();
            LabelShippingCost.Text = "$ " + priceModel.ExpediteCost.ToString();
            LabelTotalCost.Text = "$ " + priceModel.TotalCost.ToString();


            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
