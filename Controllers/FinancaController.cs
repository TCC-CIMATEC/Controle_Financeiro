using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using controleFinanceiro.Models;

namespace controleFinanceiro.Controllers
{
    public class FinancaController : Controller
    {
        private readonly ControleFinanceiroContext _context;

        public FinancaController(ControleFinanceiroContext context)
        {
            _context = context;
        }

        // GET: Financa
        public async Task<IActionResult> Index()
        {
            return View(await _context.Financa.ToListAsync());
        }

        // GET: Financa/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var financa = await _context.Financa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (financa == null)
            {
                return NotFound();
            }

            return View(financa);
        }

        // GET: Financa/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Financa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Valor,Data")] Financa financa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(financa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(financa);
        }

        // GET: Financa/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var financa = await _context.Financa.FindAsync(id);
            if (financa == null)
            {
                return NotFound();
            }
            return View(financa);
        }

        // POST: Financa/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Valor,Data")] Financa financa)
        {
            if (id != financa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(financa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FinancaExists(financa.Id))
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
            return View(financa);
        }

        // GET: Financa/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var financa = await _context.Financa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (financa == null)
            {
                return NotFound();
            }

            return View(financa);
        }

        // POST: Financa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var financa = await _context.Financa.FindAsync(id);
            _context.Financa.Remove(financa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FinancaExists(int id)
        {
            return _context.Financa.Any(e => e.Id == id);
        }
    }
}
