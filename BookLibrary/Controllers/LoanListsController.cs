using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookLibrary.Data;
using BookLibrary.Models;

namespace BookLibrary.Controllers
{
    public class LoanListsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoanListsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LoanLists
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Loans.Include(l => l.Books).Include(l => l.Customers);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> Details(int id)
        {
            var applicationDbContext = _context.Loans.Include(l => l.Books).Include(l => l.Customers);
            return View(await applicationDbContext.Where(c=>c.FK_CustomerId == id).ToListAsync());
        }

        // GET: LoanLists/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.Loans == null)
        //    {
        //        return NotFound();
        //    }

        //    var loanList = await _context.Loans
        //        .Include(l => l.Books)
        //        .Include(l => l.Customers)
        //        .FirstOrDefaultAsync(m => m.LoanListId == id);
        //    if (loanList == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(loanList);
        //}

        // GET: LoanLists/Create
        public IActionResult Create()
        {
            ViewData["FK_BookId"] = new SelectList(_context.Books, "BookId", "Title");
            ViewData["FK_CustomerId"] = new SelectList(_context.Customers, "CustomerId", "FullName");
            return View();
        }

        // POST: LoanLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LoanListId,FK_CustomerId,FK_BookId,LoanDate,DueDate,Returned")] LoanList loanList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loanList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FK_BookId"] = new SelectList(_context.Books, "BookId", "Title", loanList.FK_BookId);
            ViewData["FK_CustomerId"] = new SelectList(_context.Customers, "CustomerId", "FullName", loanList.FK_CustomerId);
            return View(loanList);
        }

        // GET: LoanLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Loans == null)
            {
                return NotFound();
            }

            var loanList = await _context.Loans.FindAsync(id);
            if (loanList == null)
            {
                return NotFound();
            }
            ViewData["FK_BookId"] = new SelectList(_context.Books, "BookId", "Title", loanList.FK_BookId);
            ViewData["FK_CustomerId"] = new SelectList(_context.Customers, "CustomerId", "FullName", loanList.FK_CustomerId);
            return View(loanList);
        }

        // POST: LoanLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LoanListId,FK_CustomerId,FK_BookId,LoanDate,DueDate,Returned")] LoanList loanList)
        {
            if (id != loanList.LoanListId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loanList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoanListExists(loanList.LoanListId))
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
            ViewData["FK_BookId"] = new SelectList(_context.Books, "BookId", "Title", loanList.FK_BookId);
            ViewData["FK_CustomerId"] = new SelectList(_context.Customers, "CustomerId", "FullName", loanList.FK_CustomerId);
            return View(loanList);
        }

        // GET: LoanLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Loans == null)
            {
                return NotFound();
            }

            var loanList = await _context.Loans
                .Include(l => l.Books)
                .Include(l => l.Customers)
                .FirstOrDefaultAsync(m => m.LoanListId == id);
            if (loanList == null)
            {
                return NotFound();
            }

            return View(loanList);
        }

        // POST: LoanLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Loans == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Loans'  is null.");
            }
            var loanList = await _context.Loans.FindAsync(id);
            if (loanList != null)
            {
                _context.Loans.Remove(loanList);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoanListExists(int id)
        {
          return _context.Loans.Any(e => e.LoanListId == id);
        }
    }
}
