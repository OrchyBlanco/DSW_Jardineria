using System;
using System.Collections.Generic;

#nullable disable

namespace DSW_JARDINERIA.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            DetallePedidos = new HashSet<DetallePedido>();
        }

        public int CodigoPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEsperada { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string Estado { get; set; }
        public string Comentarios { get; set; }
        public int CodigoCliente { get; set; }

        public virtual Cliente CodigoClienteNavigation { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
