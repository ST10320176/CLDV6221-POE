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
    public class Order_ProductController : Controller
    {
        private readonly KhumaloCraftContext _context;

        public Order_ProductController(KhumaloCraftContext context)
        {
            _context = context;
        }

        // GET: Order_Product
        public async Task<IActionResult> Index()
        {
            return View(await _context.Order_Product.ToListAsync());
        }

        // GET: Order_Product/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order_Product = await _context.Order_Product
                .FirstOrDefaultAsync(m => m.OrderProductId == id);
            if (order_Product == null)
            {
                return NotFound();
            }

            return View(order_Product);
        }

        // GET: Order_Product/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Order_Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderProductId,ProductName,Destination,Price,availability")] Order_Product order_Product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order_Product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(order_Product);
        }

        // GET: Order_Product/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order_Product = await _context.Order_Product.FindAsync(id);
            if (order_Product == null)
            {
                return NotFound();
            }
            return View(order_Product);
        }

        // POST: Order_Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderProductId,ProductName,Destination,Price,availability")] Order_Product order_Product)
        {
            if (id != order_Product.OrderProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order_Product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Order_ProductExists(order_Product.OrderProductId))
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
            return View(order_Product);
        }

        // GET: Order_Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order_Product = await _context.Order_Product
                .FirstOrDefaultAsync(m => m.OrderProductId == id);
            if (order_Product == null)
            {
                return NotFound();
            }

            return View(order_Product);
        }

        // POST: Order_Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order_Product = await _context.Order_Product.FindAsync(id);
            if (order_Product != null)
            {
                _context.Order_Product.Remove(order_Product);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Order_ProductExists(int id)
        {
            return _context.Order_Product.Any(e => e.OrderProductId == id);
        }
    }
}
