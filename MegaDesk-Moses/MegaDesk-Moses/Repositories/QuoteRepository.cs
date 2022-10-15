using MegaDesk_Moses.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Moses.Repositories
{
    /// <summary>
    /// This class is responsible for CRUD operations for the quotes that will be displayed to the user, using the Repository Pattern.
    /// Lets users create and save quotes, get a list of all quotes in the file, and delete a specific quote from the list (Think that still needs to be implemented though.)
    /// </summary>
    public class QuoteRepository
    {
        private List<DeskQuote> _deskQuotes;

        public QuoteRepository()
        {
            if (!File.Exists("quotes.json"))
            {
                _deskQuotes = new List<DeskQuote>();
            }
            else
            {
                using (StreamReader r = new StreamReader("quotes.json"))
                {
                    string json = r.ReadToEnd();
                    _deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
                }

                //var json = File.ReadAllText("quotes.json");
                //_deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
            }
        }

        public List<DeskQuote> GetQuotes()
        {
            return _deskQuotes;
        }

        public List<DeskQuote> Add(DeskQuote deskQuote)
        {
            _deskQuotes.Add(deskQuote);
            return _deskQuotes;
        }

        public List<DeskQuote> Remove(DeskQuote deskQuote)
        {
            _deskQuotes.Remove(deskQuote);
            return _deskQuotes;
        }

        public void Save()
        {
            File.WriteAllText("quotes.json", JsonConvert.SerializeObject(_deskQuotes));
        }
    }
}
