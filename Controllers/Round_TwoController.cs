using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portal_Project.Models;
using RoundTwo.Data;

namespace Portal_Project.Controllers
{
    public class Round_TwoController : Controller
    {
        private readonly Portal_ProjectContext _context;

        public Round_TwoController(Portal_ProjectContext context)
        {
            _context = context;
        }

        // GET: Round_Two
        public async Task<IActionResult> Index()
        {
            return View(await _context.Round_Two.ToListAsync());
        }

        // GET: Round_Two/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var round_Two = await _context.Round_Two
                .FirstOrDefaultAsync(m => m.Candidate_ID == id);
            if (round_Two == null)
            {
                return NotFound();
            }

            return View(round_Two);
        }

        // GET: Round_Two/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Round_Two/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Candidate_ID,Passed")] Round_Two round_Two)
        {
            if (ModelState.IsValid)
            {
                _context.Add(round_Two);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(round_Two);
        }

        // GET: Round_Two/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var round_Two = await _context.Round_Two.FindAsync(id);
            if (round_Two == null)
            {
                return NotFound();
            }
            return View(round_Two);
        }

        // POST: Round_Two/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Candidate_ID,Passed")] Round_Two round_Two)
        {
            if (id != round_Two.Candidate_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(round_Two);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Round_TwoExists(round_Two.Candidate_ID))
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
            return View(round_Two);
        }

        // GET: Round_Two/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var round_Two = await _context.Round_Two
                .FirstOrDefaultAsync(m => m.Candidate_ID == id);
            if (round_Two == null)
            {
                return NotFound();
            }

            return View(round_Two);
        }

        // POST: Round_Two/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var round_Two = await _context.Round_Two.FindAsync(id);
            _context.Round_Two.Remove(round_Two);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Round_TwoExists(int id)
        {
            return _context.Round_Two.Any(e => e.Candidate_ID == id);
        }
    }
}
