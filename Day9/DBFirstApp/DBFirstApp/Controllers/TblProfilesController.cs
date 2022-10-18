using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DBFirstApp.Models;

namespace DBFirstApp.Controllers
{
    public class TblProfilesController : Controller
    {
        private readonly dbRecruitSep2022Context _context;

        public TblProfilesController(dbRecruitSep2022Context context)
        {
            _context = context;
        }

        // GET: TblProfiles
        public async Task<IActionResult> Index()
        {
            var dbRecruitSep2022Context = _context.TblProfiles.Include(t => t.UsernameNavigation);
            return View(await dbRecruitSep2022Context.ToListAsync());
        }

        // GET: TblProfiles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TblProfiles == null)
            {
                return NotFound();
            }

            var tblProfile = await _context.TblProfiles
                .Include(t => t.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblProfile == null)
            {
                return NotFound();
            }

            return View(tblProfile);
        }

        // GET: TblProfiles/Create
        public IActionResult Create()
        {
            ViewData["Username"] = new SelectList(_context.TblUsers, "Username", "Username");
            return View();
        }

        // POST: TblProfiles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Age,Qualification,IsEmployed,NoticePeriod,CurrentCtc,Username")] TblProfile tblProfile)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblProfile);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Username"] = new SelectList(_context.TblUsers, "Username", "Username", tblProfile.Username);
            return View(tblProfile);
        }

        // GET: TblProfiles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TblProfiles == null)
            {
                return NotFound();
            }

            var tblProfile = await _context.TblProfiles.FindAsync(id);
            if (tblProfile == null)
            {
                return NotFound();
            }
            ViewData["Username"] = new SelectList(_context.TblUsers, "Username", "Username", tblProfile.Username);
            return View(tblProfile);
        }

        // POST: TblProfiles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Age,Qualification,IsEmployed,NoticePeriod,CurrentCtc,Username")] TblProfile tblProfile)
        {
            if (id != tblProfile.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblProfile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblProfileExists(tblProfile.Id))
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
            ViewData["Username"] = new SelectList(_context.TblUsers, "Username", "Username", tblProfile.Username);
            return View(tblProfile);
        }

        // GET: TblProfiles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TblProfiles == null)
            {
                return NotFound();
            }

            var tblProfile = await _context.TblProfiles
                .Include(t => t.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblProfile == null)
            {
                return NotFound();
            }

            return View(tblProfile);
        }

        // POST: TblProfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TblProfiles == null)
            {
                return Problem("Entity set 'dbRecruitSep2022Context.TblProfiles'  is null.");
            }
            var tblProfile = await _context.TblProfiles.FindAsync(id);
            if (tblProfile != null)
            {
                _context.TblProfiles.Remove(tblProfile);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblProfileExists(int id)
        {
          return _context.TblProfiles.Any(e => e.Id == id);
        }
    }
}
