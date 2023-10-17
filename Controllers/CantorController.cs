using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sistemamusicafinal.Models;

namespace sistemamusicafinal.Controllers
{
    public class CantorController : Controller
    {
        private readonly Contexto _context;

        public CantorController(Contexto context)
        {
            _context = context;
        }

        // GET: Cantor
        public async Task<IActionResult> Index()
        {
            return _context.Cantor != null ?
                        View(await _context.Cantor.ToListAsync()) :
                        Problem("Entity set 'Contexto.Cantor'  is null.");
        }

        // GET: Cantor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cantor == null)
            {
                return NotFound();
            }

            var cantor = await _context.Cantor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cantor == null)
            {
                return NotFound();
            }

            return View(cantor);
        }

        // GET: Cantor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cantor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeCantor,GeneroCantor")] Cantor cantor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cantor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cantor);
        }

        // GET: Cantor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cantor == null)
            {
                return NotFound();
            }

            var cantor = await _context.Cantor.FindAsync(id);
            if (cantor == null)
            {
                return NotFound();
            }
            return View(cantor);
        }

        // POST: Cantor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeCantor,GeneroCantor")] Cantor cantor)
        {
            if (id != cantor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cantor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CantorExists(cantor.Id))
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
            return View(cantor);
        }

        // GET: Cantor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cantor == null)
            {
                return NotFound();
            }

            var cantor = await _context.Cantor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cantor == null)
            {
                return NotFound();
            }

            return View(cantor);
        }

        // POST: Cantor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cantor == null)
            {
                return Problem("Entity set 'Contexto.Cantor'  is null.");
            }
            var cantor = await _context.Cantor.FindAsync(id);
            if (cantor != null)
            {
                _context.Cantor.Remove(cantor);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CantorExists(int id)
        {
            return (_context.Cantor?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
