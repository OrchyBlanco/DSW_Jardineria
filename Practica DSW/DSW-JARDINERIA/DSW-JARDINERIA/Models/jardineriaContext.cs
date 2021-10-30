using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DSW_JARDINERIA.Models
{
    public partial class jardineriaContext : DbContext
    {
        public jardineriaContext()
        {
        }

        public jardineriaContext(DbContextOptions<jardineriaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<DetallePedido> DetallePedidos { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<GamaProducto> GamaProductos { get; set; }
        public virtual DbSet<Oficina> Oficinas { get; set; }
        public virtual DbSet<Pago> Pagos { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           /* if (!optionsBuilder.IsConfigured)
            {
 To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.1.119;Database=jardineria; User=SA; Password=Orchyblanco.95");
            }*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.CodigoCliente)
                    .HasName("PK__cliente__4D182E8DD48B528F");

                entity.ToTable("cliente");

                entity.Property(e => e.CodigoCliente)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_cliente");

                entity.Property(e => e.ApellidoContacto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("apellido_contacto");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ciudad");

                entity.Property(e => e.CodigoEmpleadoRepVentas).HasColumnName("codigo_empleado_rep_ventas");

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codigo_postal");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("fax");

                entity.Property(e => e.LimiteCredito)
                    .HasColumnType("numeric(15, 2)")
                    .HasColumnName("limite_credito");

                entity.Property(e => e.LineaDireccion1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("linea_direccion1");

                entity.Property(e => e.LineaDireccion2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("linea_direccion2");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_cliente");

                entity.Property(e => e.NombreContacto)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nombre_contacto");

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pais");

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("region");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.CodigoEmpleadoRepVentasNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.CodigoEmpleadoRepVentas)
                    .HasConstraintName("FK__cliente__codigo___4AB81AF0");
            });

            modelBuilder.Entity<DetallePedido>(entity =>
            {
                entity.HasKey(e => new { e.CodigoPedido, e.CodigoProducto })
                    .HasName("PK__detalle___3AD5D561CDDED62D");

                entity.ToTable("detalle_pedido");

                entity.Property(e => e.CodigoPedido).HasColumnName("codigo_pedido");

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("codigo_producto");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.NumeroLinea).HasColumnName("numero_linea");

                entity.Property(e => e.PrecioUnidad)
                    .HasColumnType("numeric(15, 2)")
                    .HasColumnName("precio_unidad");

                entity.HasOne(d => d.CodigoPedidoNavigation)
                    .WithMany(p => p.DetallePedidos)
                    .HasForeignKey(d => d.CodigoPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__detalle_p__codig__5629CD9C");

                entity.HasOne(d => d.CodigoProductoNavigation)
                    .WithMany(p => p.DetallePedidos)
                    .HasForeignKey(d => d.CodigoProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__detalle_p__codig__571DF1D5");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.CodigoEmpleado)
                    .HasName("PK__empleado__CDEF1DDE06E2B2A0");

                entity.ToTable("empleado");

                entity.Property(e => e.CodigoEmpleado)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_empleado");

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido1");

                entity.Property(e => e.Apellido2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido2");

                entity.Property(e => e.CodigoJefe).HasColumnName("codigo_jefe");

                entity.Property(e => e.CodigoOficina)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codigo_oficina");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("extension");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Puesto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("puesto");

                entity.HasOne(d => d.CodigoJefeNavigation)
                    .WithMany(p => p.InverseCodigoJefeNavigation)
                    .HasForeignKey(d => d.CodigoJefe)
                    .HasConstraintName("FK__empleado__codigo__3E52440B");

                entity.HasOne(d => d.CodigoOficinaNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.CodigoOficina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__empleado__codigo__3D5E1FD2");
            });

            modelBuilder.Entity<GamaProducto>(entity =>
            {
                entity.HasKey(e => e.Gama)
                    .HasName("PK__gama_pro__4877EEE42A55CF54");

                entity.ToTable("gama_producto");

                entity.Property(e => e.Gama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gama");

                entity.Property(e => e.DescripcionHtml)
                    .IsUnicode(false)
                    .HasColumnName("descripcion_html");

                entity.Property(e => e.DescripcionTexto)
                    .IsUnicode(false)
                    .HasColumnName("descripcion_texto");

                entity.Property(e => e.Imagen)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("imagen");
            });

            modelBuilder.Entity<Oficina>(entity =>
            {
                entity.HasKey(e => e.CodigoOficina)
                    .HasName("PK__oficina__754CF298DE70BD9F");

                entity.ToTable("oficina");

                entity.Property(e => e.CodigoOficina)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codigo_oficina");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ciudad");

                entity.Property(e => e.CodigoPostal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codigo_postal");

                entity.Property(e => e.LineaDireccion1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("linea_direccion1");

                entity.Property(e => e.LineaDireccion2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("linea_direccion2");

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pais");

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("region");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Pago>(entity =>
            {
                entity.HasKey(e => new { e.CodigoCliente, e.IdTransaccion })
                    .HasName("PK__pago__CCF582842D62720E");

                entity.ToTable("pago");

                entity.Property(e => e.CodigoCliente).HasColumnName("codigo_cliente");

                entity.Property(e => e.IdTransaccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_transaccion");

                entity.Property(e => e.FechaPago)
                    .HasColumnType("date")
                    .HasColumnName("fecha_pago");

                entity.Property(e => e.FormaPago)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("forma_pago");

                entity.Property(e => e.Total)
                    .HasColumnType("numeric(15, 2)")
                    .HasColumnName("total");

                entity.HasOne(d => d.CodigoClienteNavigation)
                    .WithMany(p => p.Pagos)
                    .HasForeignKey(d => d.CodigoCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pago__codigo_cli__59FA5E80");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.CodigoPedido)
                    .HasName("PK__pedido__BBD0C51BE86EC4CD");

                entity.ToTable("pedido");

                entity.Property(e => e.CodigoPedido)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo_pedido");

                entity.Property(e => e.CodigoCliente).HasColumnName("codigo_cliente");

                entity.Property(e => e.Comentarios)
                    .IsUnicode(false)
                    .HasColumnName("comentarios");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("date")
                    .HasColumnName("fecha_entrega");

                entity.Property(e => e.FechaEsperada)
                    .HasColumnType("date")
                    .HasColumnName("fecha_esperada");

                entity.Property(e => e.FechaPedido)
                    .HasColumnType("date")
                    .HasColumnName("fecha_pedido");

                entity.HasOne(d => d.CodigoClienteNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.CodigoCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pedido__codigo_c__4E88ABD4");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.CodigoProducto)
                    .HasName("PK__producto__105107A9D06FC9F4");

                entity.ToTable("producto");

                entity.Property(e => e.CodigoProducto)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("codigo_producto");

                entity.Property(e => e.CantidadEnStock).HasColumnName("cantidad_en_stock");

                entity.Property(e => e.Descripcion)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Dimensiones)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("dimensiones");

                entity.Property(e => e.Gama)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gama");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.PrecioProveedor)
                    .HasColumnType("numeric(15, 2)")
                    .HasColumnName("precio_proveedor");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("numeric(15, 2)")
                    .HasColumnName("precio_venta");

                entity.Property(e => e.Proveedor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("proveedor");

                entity.HasOne(d => d.GamaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.Gama)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__producto__gama__534D60F1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
