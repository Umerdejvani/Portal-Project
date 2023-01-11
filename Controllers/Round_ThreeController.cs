using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portal_Project.Models;

namespace Portal_Project.Controllers
{
    public class Round_ThreeController : Controller
    {
        private readonly RoundOneContext _context;

        public Round_ThreeController(RoundOneContext context)
        {
            _context = context;
        }

        // GET: Round_Three
        public async Task<IActionResult> Index()
        {
            return View(await _context.RoundOne.ToListAsync());
        }

        // GET: Round_Three/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var round_Three = await _context.RoundOne
                .FirstOrDefaultAsync(m => m.Id == id);
            if (round_Three == null)
            {
                return NotFound();
            }

            return View(round_Three);
        }

        // GET: Round_Three/Create
        public IActionResult Create()
        {
            return View();
        }
       

        // POST: Round_Three/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Description,ImageAdmin,ImageCand")] Round_Three round_Three)
        {
            if (ModelState.IsValid)
            {
                _context.Add(round_Three);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(round_Three);
        }

        // GET: Round_Three/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var round_Three = await _context.RoundOne.FindAsync(id);
            if (round_Three == null)
            {
                return NotFound();
            }
            return View(round_Three);
        }

        // POST: Round_Three/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,Description,ImageAdmin,ImageCand")] Round_Three round_Three)
        {
            if (id != round_Three.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(round_Three);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Round_ThreeExists(round_Three.ID))
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
            return View(round_Three);
        }

        // GET: Round_Three/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var round_Three = await _context.RoundOne
                .FirstOrDefaultAsync(m => m.Id == id);
            if (round_Three == null)
            {
                return NotFound();
            }

            return View(round_Three);
        }

        // POST: Round_Three/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var round_Three = await _context.RoundOne.FindAsync(id);
            _context.RoundOne.Remove(round_Three);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Round_ThreeExists(int id)
        {
            return _context.RoundOne.Any(e => e.Id == id);
        }
    }
}
