using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HalloMVC.Data;
using HalloMVC.Models;

namespace HalloMVC.Controllers
{
    public class EisController : Controller
    {
        private readonly HalloMVCContext _context;

        public EisController(HalloMVCContext context)
        {
            _context = context;
        }

        // GET: Eis
        public async Task<IActionResult> Index()
        {
            return View(await _context.Eis.ToListAsync());
        }

        // GET: Eis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eis = await _context.Eis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eis == null)
            {
                return NotFound();
            }

            return View(eis);
        }

        // GET: Eis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Eis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Preis,MilchEis")] Eis eis)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eis);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(eis);
        }

        // GET: Eis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eis = await _context.Eis.FindAsync(id);
            if (eis == null)
            {
                return NotFound();
            }
            return View(eis);
        }

        // POST: Eis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Preis,MilchEis")] Eis eis)
        {
            if (id != eis.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eis);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EisExists(eis.Id))
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
            return View(eis);
        }

        // GET: Eis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eis = await _context.Eis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eis == null)
            {
                return NotFound();
            }

            return View(eis);
        }

        // POST: Eis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eis = await _context.Eis.FindAsync(id);
            _context.Eis.Remove(eis);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EisExists(int id)
        {
            return _context.Eis.Any(e => e.Id == id);
        }
    }
}
