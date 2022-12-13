using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SMDesigner.Data;
using SMDesigner.Models;

namespace SMDesigner.Controllers
{
    public class SacramentProgramsController : Controller
    {
        private readonly ProgramContext _context;

        public SacramentProgramsController(ProgramContext context)
        {
            _context = context;
        }

        public int NumSpeakers;


        // GET: SacramentPrograms
        public async Task<IActionResult> Index(string sortOrder, string monthString, string yearString)
        {

            ViewData["ConductorLeaderSortParm"] = String.IsNullOrEmpty(sortOrder) ? "conductL_desc" : "";
            ViewData["OpenSongSortParm"] = String.IsNullOrEmpty(sortOrder) ? "openS_desc" : "openS";
            ViewData["ProgramDateSortParm"] = sortOrder == "programDate" ? "programDate_desc" : "programDate";
            ViewData["OpenPrayerSortParm"] = String.IsNullOrEmpty(sortOrder) ? "openPrayer_desc" : "openPrayer";
            ViewData["SpeakerFullNameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "speaker_desc" : "speaker";
            ViewData["SacramentSortParm"] = String.IsNullOrEmpty(sortOrder) ? "sacrament_desc" : "sacrament";
            ViewData["SubjectSortParm"] = String.IsNullOrEmpty(sortOrder) ? "subject_desc" : "subject";
            ViewData["IntermediateNumSortParm"] = String.IsNullOrEmpty(sortOrder) ? "intermedNum_desc" : "intermedNum";
            ViewData["CloseSongSortParm"] = String.IsNullOrEmpty(sortOrder) ? "closeSong_desc" : "closeSong";
            ViewData["ClosePrayer"] = String.IsNullOrEmpty(sortOrder) ? "closePrayer_desc" : "closePrayer";
            ViewData["MonthFilter"] = monthString;
            ViewData["YearFilter"] = yearString;

            var sacramentPrograms = from s in _context.SacramentPrograms
                           select s;

            // Checking to see if Filter strings (Month, year) are null
            if (!string.IsNullOrEmpty(monthString))
            {
                sacramentPrograms = sacramentPrograms.Where(d => d.ProgramDate.Month == int.Parse(monthString));
            }

            if (!string.IsNullOrEmpty(yearString))
            {
                sacramentPrograms = sacramentPrograms.Where(d => d.ProgramDate.Year == int.Parse(yearString));
            }

            switch (sortOrder)
            {
                case "conductL_desc":
                    sacramentPrograms = sacramentPrograms.OrderByDescending(s => s.ConductorL);
                    break;
                case "openS":
                    sacramentPrograms = sacramentPrograms.OrderBy(s => s.OpenSong);
                    break;
                case "openS_desc":
                    sacramentPrograms = sacramentPrograms.OrderByDescending(s => s.OpenSong);
                    break;
                case "openPrayer":
                    sacramentPrograms = sacramentPrograms.OrderBy(s => s.OpenPrayer);
                    break;
                case "openPrayer_desc":
                    sacramentPrograms = sacramentPrograms.OrderByDescending(s => s.OpenPrayer);
                    break;
                case "speaker":
                    sacramentPrograms = sacramentPrograms.OrderBy(s => s.SpeakerFullName);
                    break;
                case "speaker_desc":
                    sacramentPrograms = sacramentPrograms.OrderByDescending(s => s.SpeakerFullName);
                    break;
                case "sacrament":
                    sacramentPrograms = sacramentPrograms.OrderBy(s => s.SacramentSong);
                    break;
                case "sacrament_desc":
                    sacramentPrograms = sacramentPrograms.OrderByDescending(s => s.SacramentSong);
                    break;
                case "subject":
                    sacramentPrograms = sacramentPrograms.OrderBy(s => s.Subject);
                    break;
                case "subject_desc":
                    sacramentPrograms = sacramentPrograms.OrderByDescending(s => s.Subject);
                    break;
                case "intermedNum":
                    sacramentPrograms = sacramentPrograms.OrderBy(s => s.IntermedNum);
                    break;
                case "intermedNum_desc":
                    sacramentPrograms = sacramentPrograms.OrderByDescending(s => s.IntermedNum);
                    break;
                case "programDate_desc":
                    sacramentPrograms = sacramentPrograms.OrderByDescending(s => s.ProgramDate);
                    break;
                case "closingSong":
                    sacramentPrograms = sacramentPrograms.OrderBy(s => s.CloseSong);
                    break;
                case "closingSong_desc":
                    sacramentPrograms = sacramentPrograms.OrderByDescending(s => s.CloseSong);
                    break;
                case "closingPrayer":
                    sacramentPrograms = sacramentPrograms.OrderBy(s => s.ClosePrayer);
                    break;
                case "closingPrayer_desc":
                    sacramentPrograms = sacramentPrograms.OrderByDescending(s => s.ClosePrayer);
                    break;
                case "programDate":
                    sacramentPrograms = sacramentPrograms.OrderBy(s => s.ProgramDate);
                    break;
                default:
                    sacramentPrograms = sacramentPrograms.OrderBy(s => s.ConductorL);
                    break;
            }
            return View(await sacramentPrograms.AsNoTracking().ToListAsync());
        }

        // GET: SacramentPrograms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacramentProgram = await _context.SacramentPrograms
                .FirstOrDefaultAsync(m => m.ID == id);
            if (sacramentProgram == null)
            {
                return NotFound();
            }

            return View(sacramentProgram);
        }

        
        // GET: SacramentPrograms/Create
        public IActionResult Create(string numSpeakers)
        {
            if (!string.IsNullOrEmpty(numSpeakers))
            {

                @ViewData["Speakers"] = int.Parse(numSpeakers);
            }


            return View();
        }

        // POST: SacramentPrograms/CreateProgram
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProgram([Bind("ID,ConductorL,OpenSong,ProgramDate,OpenPrayer,SacramentSong,SpeakerFullName,Subject,IntermedNum,CloseSong,ClosePrayer")] SacramentProgram sacramentProgram)
        {
            try
            {
                if (ModelState.IsValid)
            {
                _context.Add(sacramentProgram);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            return View(sacramentProgram);
        }

        // GET: SacramentPrograms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacramentProgram = await _context.SacramentPrograms.FindAsync(id);
            if (sacramentProgram == null)
            {
                return NotFound();
            }
            return View(sacramentProgram);
        }

        // POST: SacramentPrograms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ConductorL,OpenSong,ProgramDate,OpenPrayer,SacramentSong,SpeakerFullName,Subject,IntermedNum,CloseSong,ClosePrayer")] SacramentProgram sacramentProgram)
        {
            if (id != sacramentProgram.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sacramentProgram);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SacramentProgramExists(sacramentProgram.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sacramentProgram);
        }

        // GET: SacramentPrograms/Delete/5
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacramentProgram = await _context.SacramentPrograms
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (sacramentProgram == null)
            {
                return NotFound();
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }

            return View(sacramentProgram);
        }

        // POST: SacramentPrograms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sacramentProgram = await _context.SacramentPrograms.FindAsync(id);
            if (sacramentProgram == null)
            {
                return RedirectToAction(nameof(Index));
            }
            try
            {
                SacramentProgram sacramentProgramToDelete = new SacramentProgram() { ID = id };
                _context.Entry(sacramentProgramToDelete).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }
       
        private bool SacramentProgramExists(int id)
        {
            return _context.SacramentPrograms.Any(e => e.ID == id);
        }
    }
}
