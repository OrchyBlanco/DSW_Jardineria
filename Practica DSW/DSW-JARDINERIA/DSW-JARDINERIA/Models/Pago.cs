using System;
using System.Collections.Generic;

#nullable disable

namespace DSW_JARDINERIA.Models
{
    public partial class Pago
    {
        public int CodigoCliente { get; set; }
        public string FormaPago { get; set; }
        public string IdTransaccion { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Total { get; set; }

        public virtual Cliente CodigoClienteNavigation { get; set; }
    }
}
