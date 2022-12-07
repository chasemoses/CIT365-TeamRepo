﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        // GET: SacramentPrograms
        public async Task<IActionResult> Index()
        {
            return View(await _context.SacramentPrograms.ToListAsync());
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
        public IActionResult Create()
        {
            return View();
        }

        // POST: SacramentPrograms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ConductorL,OpenSong,ProgramDate,OpenPrayer,SacramentSong,SpeakerFullName,Subject,IntermedNum,CloseSong,ClosePrayer")] SacramentProgram sacramentProgram)
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
