using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace DSW_JARDINERIA.Models
{
    public partial class GamaProducto
    {
        public GamaProducto()
        {
            Productos = new HashSet<Producto>();
        }


        [StringLength(30)]
        public string Gama { get; set; }

        [StringLength(120)]
        public string DescripcionTexto { get; set; }

        [StringLength(120)]
        public string DescripcionHtml { get; set; }

        public string Imagen { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}