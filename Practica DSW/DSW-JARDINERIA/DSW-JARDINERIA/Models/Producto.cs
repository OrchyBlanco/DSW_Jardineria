using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DSW_JARDINERIA.Models
{
    public partial class Producto
    {
        public Producto()
        {
            DetallePedidos = new HashSet<DetallePedido>();
        }
       
        public string CodigoProducto { get; set; }
       
        [StringLength(20)]
        public string Nombre { get; set; }
        
        [StringLength(20)]
        public string Gama { get; set; }
       
        [Range(0, double.MaxValue)]
        public string Dimensiones { get; set; }
        
        [StringLength(30)]
        public string Proveedor { get; set; }
        
        [StringLength(1000)]
        public string Descripcion { get; set; }
        
        [Range(0, int.MaxValue)]
        public short CantidadEnStock { get; set; }
        
        [Range(0, double.MaxValue)]
        public decimal PrecioVenta { get; set; }
        
        [Range(0, double.MaxValue)]
        public decimal? PrecioProveedor { get; set; }

        public virtual GamaProducto GamaNavigation { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
