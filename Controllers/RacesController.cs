using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using F1Calendar.Data;
using MvcRace.Models;

namespace F1Calendar.Controllers
{
    public class RacesController : Controller
    {
        private readonly F1CalendarContext _context;

        public RacesController(F1CalendarContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string raceStatus, string searchString)
        {
            if (_context.Race == null)
            {
                return Problem("Entity set 'MvcRaceContext.Race' null.");
            }

            IQueryable<string> statusQuery = from r in _context.Race
                                            orderby r.Status
                                            select r.Status;
            var races = from r in _context.Race
                         select r;

            if (!string.IsNullOrEmpty(searchString))
            {
                races = races.Where(s => s.Name!.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(raceStatus))
            {
                races = races.Where(x => x.Status == raceStatus);
            }

            var raceStatusVM = new RaceStatusViewModel
            {
                Statuses = new SelectList(await statusQuery.Distinct().ToListAsync()),
                Races = await races.ToListAsync()
            };

            return View(raceStatusVM);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Race == null)
            {
                return NotFound();
            }

            var race = await _context.Race
                .FirstOrDefaultAsync(m => m.Id == id);
            if (race == null)
            {
                return NotFound();
            }

            return View(race);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,No,Name,Circuit,Country,StartDate,EndDate,Status,Winner")] Race race)
        {
            if (ModelState.IsValid)
            {
                _context.Add(race);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(race);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Race == null)
            {
                return NotFound();
            }

            var race = await _context.Race.FindAsync(id);
            if (race == null)
            {
                return NotFound();
            }
            return View(race);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,No,Name,Circuit,Country,StartDate,EndDate,Status,Winner")] Race race)
        {
            if (id != race.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(race);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RaceExists(race.Id))
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
            return View(race);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Race == null)
            {
                return NotFound();
            }

            var race = await _context.Race
                .FirstOrDefaultAsync(m => m.Id == id);
            if (race == null)
            {
                return NotFound();
            }

            return View(race);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Race == null)
            {
                return Problem("Entity set 'F1CalendarContext.Race'  is null.");
            }
            var race = await _context.Race.FindAsync(id);
            if (race != null)
            {
                _context.Race.Remove(race);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RaceExists(int id)
        {
          return (_context.Race?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
