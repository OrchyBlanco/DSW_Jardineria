using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DSW_JARDINERIA.Models;
using Microsoft.AspNetCore.Authorization;

namespace DSW_JARDINERIA.Controllers
{
    
    public class GamaProductoesController : Controller
    {
        private readonly jardineriaContext _context;

        public GamaProductoesController(jardineriaContext context)
        {
            _context = context;
        }

        // GET: GamaProductoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.GamaProductos.ToListAsync());
        }

        // GET: GamaProductoes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gamaProducto = await _context.GamaProductos
                .FirstOrDefaultAsync(m => m.Gama == id);
            if (gamaProducto == null)
            {
                return NotFound();
            }

            return View(gamaProducto);
        }

        // GET: GamaProductoes/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: GamaProductoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize] //CONTROL DE ACCESOS
        public async Task<IActionResult> Create([Bind("Gama,DescripcionTexto,DescripcionHtml,Imagen")] GamaProducto gamaProducto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gamaProducto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gamaProducto);
        }

        // GET: GamaProductoes/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gamaProducto = await _context.GamaProductos.FindAsync(id);
            if (gamaProducto == null)
            {
                return NotFound();
            }
            return View(gamaProducto);
        }

        // POST: GamaProductoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(string id, [Bind("Gama,DescripcionTexto,DescripcionHtml,Imagen")] GamaProducto gamaProducto)
        {
            if (id != gamaProducto.Gama)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gamaProducto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GamaProductoExists(gamaProducto.Gama))
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
            return View(gamaProducto);
        }

        // GET: GamaProductoes/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gamaProducto = await _context.GamaProductos
                .FirstOrDefaultAsync(m => m.Gama == id);
            if (gamaProducto == null)
            {
                return NotFound();
            }

            return View(gamaProducto);
        }

        // POST: GamaProductoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var gamaProducto = await _context.GamaProductos.FindAsync(id);
            _context.GamaProductos.Remove(gamaProducto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GamaProductoExists(string id)
        {
            return _context.GamaProductos.Any(e => e.Gama == id);
        }
    }
}
