using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KhumaloCraft.Data;
using KhumaloCraft.Models;
using Microsoft.AspNetCore.Authorization;

namespace KhumaloCraft.Controllers
{
    [Authorize]
    public class LoginUserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginUserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LoginUser
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoginUser.ToListAsync());
        }

        // GET: LoginUser/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginUserEntity = await _context.LoginUser
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loginUserEntity == null)
            {
                return NotFound();
            }

            return View(loginUserEntity);
        }

        // GET: LoginUser/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LoginUser/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,LastName,Mobile,Email")] LoginUserEntity loginUserEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loginUserEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loginUserEntity);
        }

        // GET: LoginUser/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginUserEntity = await _context.LoginUser.FindAsync(id);
            if (loginUserEntity == null)
            {
                return NotFound();
            }
            return View(loginUserEntity);
        }

        // POST: LoginUser/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,LastName,Mobile,Email")] LoginUserEntity loginUserEntity)
        {
            if (id != loginUserEntity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loginUserEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoginUserEntityExists(loginUserEntity.Id))
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
            return View(loginUserEntity);
        }

        // GET: LoginUser/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginUserEntity = await _context.LoginUser
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loginUserEntity == null)
            {
                return NotFound();
            }

            return View(loginUserEntity);
        }

        // POST: LoginUser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loginUserEntity = await _context.LoginUser.FindAsync(id);
            if (loginUserEntity != null)
            {
                _context.LoginUser.Remove(loginUserEntity);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoginUserEntityExists(int id)
        {
            return _context.LoginUser.Any(e => e.Id == id);
        }
    }
}
