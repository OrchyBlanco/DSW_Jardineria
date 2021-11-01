using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DSW_JARDINERIA.Models
{
    public partial class GamaProducto
    {
        public GamaProducto()
        {
            Productos = new HashSet<Producto>();
        }

        [Required]
        [StringLength(30)]
        public string Gama { get; set; }
        [Required]
        [StringLength(120)]
        public string DescripcionTexto { get; set; }
        [Required]
        [StringLength(120)]
        public string DescripcionHtml { get; set; }
        [Required]
        public string Imagen { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}