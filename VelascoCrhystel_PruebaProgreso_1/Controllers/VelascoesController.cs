using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VelascoCrhystel_PruebaProgreso_1.Data;
using VelascoCrhystel_PruebaProgreso_1.Models;

namespace VelascoCrhystel_PruebaProgreso_1.Controllers
{
    public class VelascoesController : Controller
    {
        private readonly VelascoCrhystel_PruebaProgreso_1Context _context;

        public VelascoesController(VelascoCrhystel_PruebaProgreso_1Context context)
        {
            _context = context;
        }

        // GET: Velascoes
        public async Task<IActionResult> Index()
        {
            var velascoCrhystel_PruebaProgreso_1Context = _context.Velasco.Include(v => v.Celular);
            return View(await velascoCrhystel_PruebaProgreso_1Context.ToListAsync());
        }

        // GET: Velascoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var velasco = await _context.Velasco
                .Include(v => v.Celular)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (velasco == null)
            {
                return NotFound();
            }

            return View(velasco);
        }

        // GET: Velascoes/Create
        public IActionResult Create()
        {
            ViewData["IdCelular"] = new SelectList(_context.Set<Celular>(), "Id", "Modelo");
            return View();
        }

        // POST: Velascoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Promedio,Nombre,TieneGanasEstudiar,Dia,IdCelular")] Velasco velasco)
        {
            if (ModelState.IsValid)
            {
                _context.Add(velasco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCelular"] = new SelectList(_context.Set<Celular>(), "Id", "Modelo", velasco.IdCelular);
            return View(velasco);
        }

        // GET: Velascoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var velasco = await _context.Velasco.FindAsync(id);
            if (velasco == null)
            {
                return NotFound();
            }
            ViewData["IdCelular"] = new SelectList(_context.Set<Celular>(), "Id", "Modelo", velasco.IdCelular);
            return View(velasco);
        }

        // POST: Velascoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Promedio,Nombre,TieneGanasEstudiar,Dia,IdCelular")] Velasco velasco)
        {
            if (id != velasco.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(velasco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VelascoExists(velasco.Id))
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
            ViewData["IdCelular"] = new SelectList(_context.Set<Celular>(), "Id", "Modelo", velasco.IdCelular);
            return View(velasco);
        }

        // GET: Velascoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var velasco = await _context.Velasco
                .Include(v => v.Celular)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (velasco == null)
            {
                return NotFound();
            }

            return View(velasco);
        }

        // POST: Velascoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var velasco = await _context.Velasco.FindAsync(id);
            if (velasco != null)
            {
                _context.Velasco.Remove(velasco);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VelascoExists(int id)
        {
            return _context.Velasco.Any(e => e.Id == id);
        }
    }
}
