using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KhumaloCraft.Data;
using KhumaloCraft.Models;

namespace KhumaloCraft.Controllers
{
    public class Order1Controller : Controller
    {
        private readonly KhumaloCraftContext _context;

        public Order1Controller(KhumaloCraftContext context)
        {
            _context = context;
        }

        // GET: Order1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Order1.ToListAsync());
        }

        // GET: Order1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order1 = await _context.Order1
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order1 == null)
            {
                return NotFound();
            }

            return View(order1);
        }

        // GET: Order1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Order1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderID,ProductName,OrderDate,Status,Quantity")] Order1 order1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(order1);
        }

        // GET: Order1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order1 = await _context.Order1.FindAsync(id);
            if (order1 == null)
            {
                return NotFound();
            }
            return View(order1);
        }

        // POST: Order1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,ProductName,OrderDate,Status,Quantity")] Order1 order1)
        {
            if (id != order1.OrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Order1Exists(order1.OrderID))
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
            return View(order1);
        }

        // GET: Order1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order1 = await _context.Order1
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order1 == null)
            {
                return NotFound();
            }

            return View(order1);
        }

        // POST: Order1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order1 = await _context.Order1.FindAsync(id);
            if (order1 != null)
            {
                _context.Order1.Remove(order1);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Order1Exists(int id)
        {
            return _context.Order1.Any(e => e.OrderID == id);
        }
    }
}
