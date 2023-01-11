using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portal_Project.Models;

namespace Portal_Project.Controllers
{
    public class RoundOnesController : Controller
    {
        private readonly RoundOneContext _context;

        public RoundOnesController(RoundOneContext context)
        {
            _context = context;
        }

        // GET: RoundOnes
        public async Task<IActionResult> Index()
        {
            return View(await _context.RoundOne.ToListAsync());
        }

        // GET: RoundOnes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roundOne = await _context.RoundOne
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roundOne == null)
            {
                return NotFound();
            }

            return View(roundOne);
        }

        // GET: RoundOnes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoundOnes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,canidateName,fatherName,AddressLine1,AddressLine2,PhoneOne,PhoneSec,Email,City,Age,DateOfBirth,CNIC,PositionAF,DesiredSalary,StartEmpDate,OldEmp,HSCEdu,FSCEdu,BSEdu,MSEdu,Skills,Qualification,CurrentEmp,CE_Position,CE_Salary,CE_Reason,CE_StartDate,CE_MayContact,LastEmp,LE_Position,LE_Salary,LE_Reason,LE_StartDate,LE_EndDate,SecondLastEmp,SLE_Position,SLE_Salary,SLE_Reason,SLE_StartDate,SLE_EndDate")] RoundOne roundOne)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roundOne);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roundOne);
        }

        // GET: RoundOnes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roundOne = await _context.RoundOne.FindAsync(id);
            if (roundOne == null)
            {
                return NotFound();
            }
            return View(roundOne);
        }

        // POST: RoundOnes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,canidateName,fatherName,AddressLine1,AddressLine2,PhoneOne,PhoneSec,Email,City,Age,DateOfBirth,CNIC,PositionAF,DesiredSalary,StartEmpDate,OldEmp,HSCEdu,FSCEdu,BSEdu,MSEdu,Skills,Qualification,CurrentEmp,CE_Position,CE_Salary,CE_Reason,CE_StartDate,CE_MayContact,LastEmp,LE_Position,LE_Salary,LE_Reason,LE_StartDate,LE_EndDate,SecondLastEmp,SLE_Position,SLE_Salary,SLE_Reason,SLE_StartDate,SLE_EndDate")] RoundOne roundOne)
        {
            if (id != roundOne.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roundOne);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoundOneExists(roundOne.Id))
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
            return View(roundOne);
        }

        // GET: RoundOnes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roundOne = await _context.RoundOne
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roundOne == null)
            {
                return NotFound();
            }

            return View(roundOne);
        }

        // POST: RoundOnes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roundOne = await _context.RoundOne.FindAsync(id);
            _context.RoundOne.Remove(roundOne);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoundOneExists(int id)
        {
            return _context.RoundOne.Any(e => e.Id == id);
        }
    }
}
