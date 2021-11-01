using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DSW_JARDINERIA.Models;
using Microsoft.AspNetCore.Authorization;
using X.PagedList;

namespace DSW_JARDINERIA.Controllers
{
    
    public class ProductoesController : Controller
    {
        private readonly jardineriaContext _context;
        public int tam_pagina = 15;
       // public string ordenacion;

        public ProductoesController(jardineriaContext context)
        {
            _context = context;
        }

        // Paginacion  + GET Productos
        public IActionResult Index(string busqueda_actual,string buscado, int? nueva_pagina)
        {
            //QUERY DE SELECCION
            var product_select = from s in _context.Productos select s;
            //ASIGNACION DE PAGINACION
            if (buscado != null)
            {
                nueva_pagina = 1;
            }
            else
            {
                buscado = busqueda_actual;
            }
            if (!String.IsNullOrEmpty(buscado))
            {
                product_select = product_select.Where(x => x.Nombre.StartsWith(buscado) || buscado == null);
            }
            ViewData["busqueda_actual"] = buscado;

            /*
                        // ORDENACION DE PRODUCTOS --> Revison para aplicar en un Futuro
                        switch (ordenacion)
                        {
                            case "ordenar_nombre_ascendente":
                                product_select = product_select.OrderBy(atributo => atributo.Nombre);
                                break;
                            case "ordenar_nombre_descendente":
                                product_select = product_select.OrderByDescending(atributo => atributo.Nombre);
                                break;
                            case "ordenar_dimensiones_ascendente":
                                product_select = product_select.OrderBy(atributo => atributo.Dimensiones);
                                break;
                            case "ordenar_dimensiones_descendente":
                                product_select = product_select.OrderByDescending(atributo => atributo.Dimensiones);
                                break;
                            case "ordenar_descripcion_ascendente":
                                product_select = product_select.OrderBy(atributo => atributo.Descripcion);
                                break;
                            case "ordenar_descripcion_descendente":
                                product_select = product_select.OrderByDescending(atributo => atributo.Descripcion);
                                break;
                        }
                        //DATOS DE ORDENACION

                        ViewData["ordenar_nombre"] = String.IsNullOrEmpty(ordenacion) ? "ordenar_nombre_ascendente":
                            ordenacion == "ordenar_nombre_ascendente" ? "ordenar_nombre_descendente":"";

                        ViewData["ordenar_dimensiones"] = String.IsNullOrEmpty(ordenacion) ? "ordenar_dimensiones_ascendente" :
                            ordenacion == "ordenar_dimensiones_ascendente" ? "ordenar_dimensiones_descendente" : "";

                        ViewData["ordenar_proveedor"] = String.IsNullOrEmpty(ordenacion) ? "ordenar_proveedor_ascendente" :
                            ordenacion == "ordenar_proveedor_ascendente" ? "ordenar_proveedor_descendente" : "";

                        ViewData["ordenar_descripcion"] = String.IsNullOrEmpty(ordenacion) ? "ordenar_descripcion_ascendente":
                            ordenacion == "ordenar_descripcion_ascendente" ? "ordenar_descripcion_descendente": "";

                        ViewData["ordenar_cantidadenstock"] = String.IsNullOrEmpty(ordenacion) ? "ordenar_cantidadenstock_ascendente" :
                            ordenacion == "ordenar_cantidadenstock_ascendente" ? "ordenar_cantidadenstock_descendente" : "";

                        ViewData["ordenar_precioventa"] = String.IsNullOrEmpty(ordenacion) ? "ordenar_precioventa_ascendente" :
                            ordenacion == "ordenar_precioventa_ascendente" ? "ordenar_precioventa_descendente" : "";

                        ViewData["ordenar_precioproveedor"] = String.IsNullOrEmpty(ordenacion) ? "ordenar_precioproveedor_ascendente" :
                            ordenacion == "ordenar_precioproveedor_ascendente" ? "ordenar_precioproveedor_descendente" : "";

                        ViewData["ordenar_gamanavigation"] = String.IsNullOrEmpty(ordenacion) ? "ordenar_gamanavigation_ascendente" :
                            ordenacion == "ordenar_gamanavigation_ascendente" ? "ordenar_gamanavigation_descendente" : "";

                        // TENDREMOS QUE GENERAR UN IF/ELSE IF/ELSE POR CADA OPCION A ORDENAR.
                        //ORDENAR NOMBRE
                        if (String.IsNullOrEmpty(ordenacion))
                        {
                            ViewData["ordenar_nombre"] = "ordenar_nombre_ascendente";
                        }
                        else if (ordenacion == "ordenar_nombre_ascendente")
                        {
                            ViewData["ordenar_nombre"] = "ordenar_nombre_descendente";
                        }
                        else
                        {
                            ViewData["ordenar_nombre"] = "";
                        }
                        //ORDENAR DIMENSIONES
                        if (String.IsNullOrEmpty(ordenacion))
                        {
                            ViewData["ordenar_dimensiones"] = "ordenar_dimensiones_ascendente";
                        }
                        else if (ordenacion == "ordenar_dimensiones_ascendente")
                        {
                            ViewData["ordenar_dimensiones"] = "ordenar_dimensiones_descendente";
                        }
                        else
                        {
                            ViewData["ordenar_dimensiones"] = "";
                        }
                        //ORDENAR PROVEEDOR
                        if (String.IsNullOrEmpty(ordenacion))
                        {
                            ViewData["ordenar_proveedor"] = "ordenar_proveedor_ascendente";
                        }
                        else if (ordenacion == "ordenar_proveedor_ascendente")
                        {
                            ViewData["ordenar_proveedor"] = "ordenar_proveedor_descendente";
                        }
                        else
                        {
                            ViewData["ordenar_proveedor"] = "";
                        }

                        //ORDENAR DESCRIPCION
                        if (String.IsNullOrEmpty(ordenacion))
                        {
                            ViewData["ordenar_descripcion"] =
                              "ordenar_descripcion_ascendente";
                        }
                        else if (ordenacion == "ordenar_descripcion_ascendente")
                        {
                            ViewData["ordenar_descripcion"] =
                              "ordenar_descripcion_descendente";
                        }
                        else
                        {
                            ViewData["ordenar_descripcion"] = "";
                        }
                        //ORDENAR CANTIDADENSTOCK
                        if (String.IsNullOrEmpty(ordenacion))
                        {
                            ViewData["ordenar_cantidadenstock"] = "ordenar_cantidadenstock_ascendente";
                        }
                        else if (ordenacion == "ordenar_cantidadenstock_ascendente")
                        {
                            ViewData["ordenar_cantidadenstock"] = "ordenar_cantidadenstock_descendente";
                        }
                        else
                        {
                            ViewData["ordenar_cantidadenstock"] = "";
                        }

                        //ORDENAR PRECIOVENTA
                        if (String.IsNullOrEmpty(ordenacion))
                        {
                            ViewData["ordenar_precioventa"] = "ordenar_precioventa_ascendente";
                        }
                        else if (ordenacion == "ordenar_precioventa_ascendente")
                        {
                            ViewData["ordenar_precioventa"] = "ordenar_precioventa_descendente";
                        }
                        else
                        {
                            ViewData["ordenar_precioventa"] = "";
                        }

                        //ORDENAR PRECIOPROVEEDOR
                        if (String.IsNullOrEmpty(ordenacion))
                        {
                            ViewData["ordenar_precioproveedor"] = "ordenar_precioproveedor_ascendente";
                        }
                        else if (ordenacion == "ordenar_precioproveedor_ascendente")
                        {
                            ViewData["ordenar_precioproveedor"] = "ordenar_precioproveedor_descendente";
                        }
                        else
                        {
                            ViewData["ordenar_precioproveedor"] = "";
                        }

                        //ORDENAR GAMANAVIGATION
                        if (String.IsNullOrEmpty(ordenacion))
                        {
                            ViewData["ordenar_gamanavigation"] = "ordenar_gamanavigation_ascendente";
                        }
                        else if (ordenacion == "ordenar_gamanavigation_ascendente")
                        {
                            ViewData["ordenar_gamanavigation"] = "ordenar_gamanavigation_descendente";
                        }
                        else
                        {
                            ViewData["ordenar_gamanavigation"] = "";
                        }
            */

            return View(product_select.ToList().ToPagedList(nueva_pagina ?? 1, tam_pagina));
        }
       

        

        // GET: Productoes/Details/5

        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .Include(p => p.GamaNavigation)
                .FirstOrDefaultAsync(m => m.CodigoProducto == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Productoes/Create
        [Authorize] //CONTROL DE ACCESOS
        public IActionResult Create()
        {
            ViewData["Gama"] = new SelectList(_context.GamaProductos, "Gama", "Gama");
            return View();
        }

        // POST: Productoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize] //CONTROL DE ACCESOS
        public async Task<IActionResult> Create([Bind("CodigoProducto,Nombre,Gama,Dimensiones,Proveedor,Descripcion,CantidadEnStock,PrecioVenta,PrecioProveedor")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Gama"] = new SelectList(_context.GamaProductos, "Gama", "Gama", producto.Gama);
            return View(producto);
        }

        // GET: Productoes/Edit/5
        [Authorize] //CONTROL DE ACCESOS
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            ViewData["Gama"] = new SelectList(_context.GamaProductos, "Gama", "Gama", producto.Gama);
            return View(producto);
        }

        // POST: Productoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize] //CONTROL DE ACCESOS
        public async Task<IActionResult> Edit(string id, [Bind("CodigoProducto,Nombre,Gama,Dimensiones,Proveedor,Descripcion,CantidadEnStock,PrecioVenta,PrecioProveedor")] Producto producto)
        {
            if (id != producto.CodigoProducto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.CodigoProducto))
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
            ViewData["Gama"] = new SelectList(_context.GamaProductos, "Gama", "Gama", producto.Gama);
            return View(producto);
        }

        // GET: Productoes/Delete/5
        [Authorize] //CONTROL DE ACCESOS
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .Include(p => p.GamaNavigation)
                .FirstOrDefaultAsync(m => m.CodigoProducto == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Productoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize] //CONTROL DE ACCESOS
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var producto = await _context.Productos.FindAsync(id);
            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(string id)
        {
            return _context.Productos.Any(e => e.CodigoProducto == id);
        }
    }
}
