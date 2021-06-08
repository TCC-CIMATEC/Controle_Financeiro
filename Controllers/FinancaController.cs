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
            var controleFinanceiroContext = _context.Financa.Include(f => f.Categoria).Include(f => f.Modalidade).Include(f => f.Tipo).Include(f => f.Usuario);
            return View(await controleFinanceiroContext.ToListAsync());
        }

        // GET: FinancaByUsuarioId
        public async Task<IActionResult> FindByUsuarioId(int? usuarioId)
        {
            var controleFinanceiroContext = _context.Financa.Where(f => f.UsuarioId == usuarioId).Include(f => f.Categoria).Include(f => f.Modalidade).Include(f => f.Tipo).Include(f => f.Usuario);
            return View(await controleFinanceiroContext.ToListAsync());
        }

        // GET: Financa/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var financa = await _context.Financa
                .Include(f => f.Categoria)
                .Include(f => f.Modalidade)
                .Include(f => f.Tipo)
                .Include(f => f.Usuario)
                .FirstOrDefaultAsync(m => m.FinancaId == id);
            if (financa == null)
            {
                return NotFound();
            }

            return View(financa);
        }

        // GET: Financa/Create
        public IActionResult Create(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "CategoriaId", "Descricao");
            ViewData["ModalidadeId"] = new SelectList(_context.Modalidade, "ModalidadeId", "Descricao");
            ViewData["TipoId"] = new SelectList(_context.Tipo, "TipoId", "Descricao");
            ViewData["UsuarioId"] = new SelectList(_context.Usuario.Where(usu => usu.UsuarioId == id), "UsuarioId", "Nome");
            return View();
        }

        // POST: Financa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FinancaId,Valor,DataFinanca,ModalidadeId,CategoriaId,TipoId,UsuarioId")] Financa financa, int UsuarioId)
        {
            if (ModelState.IsValid)
            {
                _context.Add(financa);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Usuario", new { id = UsuarioId });
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "CategoriaId", "Descricao", financa.CategoriaId);
            ViewData["ModalidadeId"] = new SelectList(_context.Modalidade, "ModalidadeId", "Descricao", financa.ModalidadeId);
            ViewData["TipoId"] = new SelectList(_context.Tipo, "TipoId", "Descricao", financa.TipoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "UsuarioId", "Nome", financa.UsuarioId);
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
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "CategoriaId", "Descricao", financa.CategoriaId);
            ViewData["ModalidadeId"] = new SelectList(_context.Modalidade, "ModalidadeId", "Descricao", financa.ModalidadeId);
            ViewData["TipoId"] = new SelectList(_context.Tipo, "TipoId", "Descricao", financa.TipoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "UsuarioId", "Nome", financa.UsuarioId);
            return View(financa);
        }

        // POST: Financa/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FinancaId,Valor,DataFinanca,ModalidadeId,CategoriaId,TipoId,UsuarioId")] Financa financa)
        {
            if (id != financa.FinancaId)
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
                    if (!FinancaExists(financa.FinancaId))
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
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "CategoriaId", "Descricao", financa.CategoriaId);
            ViewData["ModalidadeId"] = new SelectList(_context.Modalidade, "ModalidadeId", "Descricao", financa.ModalidadeId);
            ViewData["TipoId"] = new SelectList(_context.Tipo, "TipoId", "Descricao", financa.TipoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "UsuarioId", "Nome", financa.UsuarioId);
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
                .Include(f => f.Categoria)
                .Include(f => f.Modalidade)
                .Include(f => f.Tipo)
                .Include(f => f.Usuario)
                .FirstOrDefaultAsync(m => m.FinancaId == id);
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
            return _context.Financa.Any(e => e.FinancaId == id);
        }
    }
}
