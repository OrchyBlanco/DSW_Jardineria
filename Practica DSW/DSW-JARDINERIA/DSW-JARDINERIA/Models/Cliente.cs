using System;
using System.Collections.Generic;

#nullable disable

namespace DSW_JARDINERIA.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Pagos = new HashSet<Pago>();
            Pedidos = new HashSet<Pedido>();
        }

        public int CodigoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string NombreContacto { get; set; }
        public string ApellidoContacto { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string LineaDireccion1 { get; set; }
        public string LineaDireccion2 { get; set; }
        public string Ciudad { get; set; }
        public string Region { get; set; }
        public string Pais { get; set; }
        public string CodigoPostal { get; set; }
        public int? CodigoEmpleadoRepVentas { get; set; }
        public decimal? LimiteCredito { get; set; }

        public virtual Empleado CodigoEmpleadoRepVentasNavigation { get; set; }
        public virtual ICollection<Pago> Pagos { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
