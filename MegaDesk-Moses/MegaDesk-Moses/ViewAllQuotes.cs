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
    public partial class ViewAllQuotes : Form
    {
        private QuoteRepository _quoteRepository;

        public ViewAllQuotes(QuoteRepository quoteRepository)
        {
            _quoteRepository = quoteRepository;

            List<DeskQuote> deskQuotes = _quoteRepository.GetQuotes();

            InitializeComponent();

            

            foreach (var deskQuote in deskQuotes)
            {
                ListViewItem listItem = new ListViewItem(deskQuote.Name);
                listItem.SubItems.Add(deskQuote.QuoteDate.ToShortDateString());
                listItem.SubItems.Add(deskQuote.Desk.Width.ToString());
                listItem.SubItems.Add(deskQuote.Desk.Depth.ToString());
                listItem.SubItems.Add(deskQuote.Desk.NumberOfDrawers.ToString());
                listItem.SubItems.Add(deskQuote.Desk.SurfaceMaterials.Name);
                listItem.SubItems.Add(deskQuote.RushOrderDay.DisplayName);
                listItem.SubItems.Add(deskQuote.TotalPrice.ToString());

                listView1.Items.Add(listItem);
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
