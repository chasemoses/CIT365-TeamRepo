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
    public partial class MainMenu : Form
    {
        private QuoteRepository _quoteRepository;


        public MainMenu()
        {
            _quoteRepository = new QuoteRepository();
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAddQuote_Click(object sender, EventArgs e)
        {
            DeskQuote DeskQuote = DeskQuote.CreateEmpty();
            
            // Display Add Quote stuff.
            var AddQuote = new AddQuote(DeskQuote);
            AddQuote.ShowDialog();

            if (DeskQuote.IsComplete)
            {
                DisplayQuote displayQuote = new DisplayQuote(DeskQuote);
                displayQuote.ShowDialog();

                // Save Quote from AddQuote's stuff.
                _quoteRepository.Add(DeskQuote);
                _quoteRepository.Save();
            }
        }


        private void BtnViewQuote_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotes = new ViewAllQuotes(_quoteRepository);
            viewAllQuotes.ShowDialog();
        }

        private void BtnSearchQuotes_Click(object sender, EventArgs e)
        {
            SearchAllQuotes searchAllQuotes = new SearchAllQuotes(_quoteRepository);
            searchAllQuotes.ShowDialog();
        }
    }
}
