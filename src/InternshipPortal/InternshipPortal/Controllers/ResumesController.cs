using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InternshipPortal.Data;
using InternshipPortal.Models;

namespace InternshipPortal
{
    public class ResumesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResumesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Resumes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Resumes.ToListAsync());
        }

        // GET: Resumes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumes = await _context.Resumes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (resumes == null)
            {
                return NotFound();
            }

            return View(resumes);
        }

        // GET: Resumes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Resumes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,name")] Resumes resumes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(resumes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(resumes);
        }

        // GET: Resumes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumes = await _context.Resumes.FindAsync(id);
            if (resumes == null)
            {
                return NotFound();
            }
            return View(resumes);
        }

        // POST: Resumes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,name")] Resumes resumes)
        {
            if (id != resumes.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(resumes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResumesExists(resumes.ID))
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
            return View(resumes);
        }

        // GET: Resumes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumes = await _context.Resumes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (resumes == null)
            {
                return NotFound();
            }

            return View(resumes);
        }

        // POST: Resumes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resumes = await _context.Resumes.FindAsync(id);
            _context.Resumes.Remove(resumes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResumesExists(int id)
        {
            return _context.Resumes.Any(e => e.ID == id);
        }
    }
}
