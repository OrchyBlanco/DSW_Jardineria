using System;
using System.Collections.Generic;

#nullable disable

namespace DSW_JARDINERIA.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            Clientes = new HashSet<Cliente>();
            InverseCodigoJefeNavigation = new HashSet<Empleado>();
        }

        public int CodigoEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Extension { get; set; }
        public string Email { get; set; }
        public string CodigoOficina { get; set; }
        public int? CodigoJefe { get; set; }
        public string Puesto { get; set; }

        public virtual Empleado CodigoJefeNavigation { get; set; }
        public virtual Oficina CodigoOficinaNavigation { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Empleado> InverseCodigoJefeNavigation { get; set; }
    }
}
