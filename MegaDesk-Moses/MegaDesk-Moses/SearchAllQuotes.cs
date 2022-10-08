using MegaDesk_Moses.Models;
using MegaDesk_Moses.Repositories;
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
    public partial class SearchAllQuotes : Form
    {
        private SurfaceMaterials[] _surfaceMaterials;
        private QuoteRepository _quoteRepository;
        private List<DeskQuote> _deskQuotes;
        public SearchAllQuotes(QuoteRepository quoteRepository)
        {
            _surfaceMaterials = SurfaceMaterials.List.ToArray();

            _quoteRepository = quoteRepository;

            _deskQuotes = _quoteRepository.GetQuotes();

            InitializeComponent();

            CBMaterialSearch.Items.AddRange(_surfaceMaterials);


            // Find out what the ComboBox value is and call methods to return a filtered list based on material type
            // and call another method to update the listView.
            var materialItem = CBMaterialSearch.Text;

            UpdateViewList(materialItem, _deskQuotes);
            
        }

        private void CBMaterialSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            // Clear what is currently in the list.
            LVSearch.Items.Clear();

            // Get new value for combo box and pass it to update the viewList.
            var materialItem = CBMaterialSearch.Text;

            UpdateViewList(materialItem, _deskQuotes);

        }

        private void UpdateViewList(string materialItem, List<DeskQuote> deskQuotes)
        {

            var filteredQuotes = FilterQuotesByMaterialName(materialItem, deskQuotes);

            // Add Quotes to list view
            foreach (var deskQuote in filteredQuotes)
            {
                ListViewItem listItem = new ListViewItem(deskQuote.Name);
                listItem.SubItems.Add(deskQuote.QuoteDate.ToShortDateString());
                listItem.SubItems.Add(deskQuote.Desk.Width.ToString());
                listItem.SubItems.Add(deskQuote.Desk.Depth.ToString());
                listItem.SubItems.Add(deskQuote.Desk.NumberOfDrawers.ToString());
                listItem.SubItems.Add(deskQuote.Desk.SurfaceMaterials.Name);
                listItem.SubItems.Add(deskQuote.RushOrderDay.DisplayName);
                listItem.SubItems.Add(deskQuote.TotalPrice.ToString());

                LVSearch.Items.Add(listItem);
            }
        }

        private List<DeskQuote> FilterQuotesByMaterialName(string materialItem, List<DeskQuote> deskQuotes)
        {
            return deskQuotes.Where(s => s.Desk.SurfaceMaterials.Name == materialItem).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
