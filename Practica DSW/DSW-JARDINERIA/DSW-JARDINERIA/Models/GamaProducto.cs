using System;
using System.Collections.Generic;

#nullable disable

namespace DSW_JARDINERIA.Models
{
    public partial class GamaProducto
    {
        public GamaProducto()
        {
            Productos = new HashSet<Producto>();
        }

        public string Gama { get; set; }
        public string DescripcionTexto { get; set; }
        public string DescripcionHtml { get; set; }
        public string Imagen { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
