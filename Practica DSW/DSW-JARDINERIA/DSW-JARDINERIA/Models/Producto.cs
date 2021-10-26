using System;
using System.Collections.Generic;

#nullable disable

namespace DSW_JARDINERIA.Models
{
    public partial class Producto
    {
        public Producto()
        {
            DetallePedidos = new HashSet<DetallePedido>();
        }

        public string CodigoProducto { get; set; }
        public string Nombre { get; set; }
        public string Gama { get; set; }
        public string Dimensiones { get; set; }
        public string Proveedor { get; set; }
        public string Descripcion { get; set; }
        public short CantidadEnStock { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal? PrecioProveedor { get; set; }

        public virtual GamaProducto GamaNavigation { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
