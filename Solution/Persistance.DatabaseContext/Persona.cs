namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Persona")]
    public partial class Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Persona()
        {
            Actualizacion_Controles = new HashSet<Actualizacion_Controles>();
            Actualizacion_Controles_Detalle = new HashSet<Actualizacion_Controles_Detalle>();
            Almacen_Sol_Produccion = new HashSet<Almacen_Sol_Produccion>();
            Caja_Apertura_Dotacion = new HashSet<Caja_Apertura_Dotacion>();
            cc_Pagos = new HashSet<cc_Pagos>();
            Cierre_Inventario = new HashSet<Cierre_Inventario>();
            co_Reportes_Contables = new HashSet<co_Reportes_Contables>();
            Condiciones_Financieras = new HashSet<Condiciones_Financieras>();
            Contactoes = new HashSet<Contacto>();
            Control_Procesos = new HashSet<Control_Procesos>();
            Cotizacions = new HashSet<Cotizacion>();
            Cotizacions1 = new HashSet<Cotizacion>();
            Cotizacions2 = new HashSet<Cotizacion>();
            Cotizacion_Simple = new HashSet<Cotizacion_Simple>();
            Cotizacion_Simple1 = new HashSet<Cotizacion_Simple>();
            Cotizacion_Simple2 = new HashSet<Cotizacion_Simple>();
            cp_Pagos = new HashSet<cp_Pagos>();
            CProyectos_Personal = new HashSet<CProyectos_Personal>();
            CProyectos_Personas = new HashSet<CProyectos_Personas>();
            Datos_Embarque = new HashSet<Datos_Embarque>();
            Devolucion_Cliente = new HashSet<Devolucion_Cliente>();
            Devolucion_Cliente1 = new HashSet<Devolucion_Cliente>();
            Domicilios = new HashSet<Domicilio>();
            Estadisticos_Compras_Articulo_TMP = new HashSet<Estadisticos_Compras_Articulo_TMP>();
            Estadisticos_Compras_Proveedor_TMP = new HashSet<Estadisticos_Compras_Proveedor_TMP>();
            Estadisticos_Compras_Proveedor_TMP1 = new HashSet<Estadisticos_Compras_Proveedor_TMP>();
            Estadisticos_Ventas_Articulo_TMP = new HashSet<Estadisticos_Ventas_Articulo_TMP>();
            Estadisticos_Ventas_Cliente_TMP = new HashSet<Estadisticos_Ventas_Cliente_TMP>();
            Estadisticos_Ventas_Cliente_TMP1 = new HashSet<Estadisticos_Ventas_Cliente_TMP>();
            Gastos_Asignacion_Deudores = new HashSet<Gastos_Asignacion_Deudores>();
            Grupo_Persona = new HashSet<Grupo_Persona>();
            Grupo_Persona_Detalle = new HashSet<Grupo_Persona_Detalle>();
            Historico_Produccion = new HashSet<Historico_Produccion>();
            Historico_Produccion1 = new HashSet<Historico_Produccion>();
            Homologacion_Articulos = new HashSet<Homologacion_Articulos>();
            Homologacion_Modelos = new HashSet<Homologacion_Modelos>();
            ks_Pedido = new HashSet<ks_Pedido>();
            ks_Pedido_Entrega = new HashSet<ks_Pedido_Entrega>();
            Modeloes = new HashSet<Modelo>();
            Modelo_Producto_Enc = new HashSet<Modelo_Producto_Enc>();
            Orden_Produccion = new HashSet<Orden_Produccion>();
            Periodos_Siguientes_Sel = new HashSet<Periodos_Siguientes_Sel>();
            Proveedor_Iva = new HashSet<Proveedor_Iva>();
            cc_Proceso_Pago = new HashSet<cc_Proceso_Pago>();
            cc_Proceso_Pago1 = new HashSet<cc_Proceso_Pago>();
            cp_Proceso_Contabilidad = new HashSet<cp_Proceso_Contabilidad>();
            cp_Proceso_Pago = new HashSet<cp_Proceso_Pago>();
            cp_Proceso_Pago1 = new HashSet<cp_Proceso_Pago>();
            Persona_Relacion = new HashSet<Persona_Relacion>();
            Productos_Conceptos_Cliente = new HashSet<Productos_Conceptos_Cliente>();
            Proveedors = new HashSet<Proveedor>();
            Recetas = new HashSet<Receta>();
            Relacion_Caja_Cajero = new HashSet<Relacion_Caja_Cajero>();
            Relacion_Cajero_Almacen = new HashSet<Relacion_Cajero_Almacen>();
            Revision_Calidad = new HashSet<Revision_Calidad>();
            Salida_Almacen = new HashSet<Salida_Almacen>();
            Taller_Calculo_CP = new HashSet<Taller_Calculo_CP>();
            Usuario_Tipo_Cliente = new HashSet<Usuario_Tipo_Cliente>();
            Vendedors = new HashSet<Vendedor>();
            Venta_Caja = new HashSet<Venta_Caja>();
            Venta_Caja1 = new HashSet<Venta_Caja>();
            Venta_Caja2 = new HashSet<Venta_Caja>();
            Venta_Caja3 = new HashSet<Venta_Caja>();
            Venta_Caja_Apertura = new HashSet<Venta_Caja_Apertura>();
            Venta_Caja_Cierre = new HashSet<Venta_Caja_Cierre>();
            Venta_Caja_Cierre1 = new HashSet<Venta_Caja_Cierre>();
            Viaticos_Solicitud = new HashSet<Viaticos_Solicitud>();
            Viaticos_Solicitud1 = new HashSet<Viaticos_Solicitud>();
            Control_Procesos1 = new HashSet<Control_Procesos>();
            Clientes = new HashSet<Cliente>();
        }

        public int? Numero_Empresa { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [StringLength(300)]
        public string Nombre_Completo { get; set; }

        [StringLength(100)]
        public string Paterno { get; set; }

        [StringLength(100)]
        public string Materno { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(25)]
        public string Nombre_Corto { get; set; }

        [StringLength(18)]
        public string RFC { get; set; }

        [StringLength(18)]
        public string CURP { get; set; }

        [StringLength(64)]
        public string Telefono { get; set; }

        [StringLength(64)]
        public string Fax { get; set; }

        [StringLength(64)]
        public string Celular { get; set; }

        [StringLength(64)]
        public string Radiolocalizador { get; set; }

        [StringLength(50)]
        public string correo_electronico { get; set; }

        [StringLength(1)]
        public string Personalidad_juridica { get; set; }

        public DateTime? Fecha_Nacimiento { get; set; }

        public DateTime? Fecha_Alta { get; set; }

        public DateTime? Fecha_Cambio { get; set; }

        [StringLength(100)]
        public string Numero_Confia { get; set; }

        public byte? General { get; set; }

        public byte? Transportista { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Actualizacion_Controles> Actualizacion_Controles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Actualizacion_Controles_Detalle> Actualizacion_Controles_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Almacen_Sol_Produccion> Almacen_Sol_Produccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Apertura_Dotacion> Caja_Apertura_Dotacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cc_Pagos> cc_Pagos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cierre_Inventario> Cierre_Inventario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<co_Reportes_Contables> co_Reportes_Contables { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Condiciones_Financieras> Condiciones_Financieras { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contacto> Contactoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Control_Procesos> Control_Procesos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion> Cotizacions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion> Cotizacions1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion> Cotizacions2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion_Simple> Cotizacion_Simple { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion_Simple> Cotizacion_Simple1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion_Simple> Cotizacion_Simple2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cp_Pagos> cp_Pagos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CProyectos_Personal> CProyectos_Personal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CProyectos_Personas> CProyectos_Personas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Datos_Embarque> Datos_Embarque { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Devolucion_Cliente> Devolucion_Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Devolucion_Cliente> Devolucion_Cliente1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Domicilio> Domicilios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estadisticos_Compras_Articulo_TMP> Estadisticos_Compras_Articulo_TMP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estadisticos_Compras_Proveedor_TMP> Estadisticos_Compras_Proveedor_TMP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estadisticos_Compras_Proveedor_TMP> Estadisticos_Compras_Proveedor_TMP1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estadisticos_Ventas_Articulo_TMP> Estadisticos_Ventas_Articulo_TMP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estadisticos_Ventas_Cliente_TMP> Estadisticos_Ventas_Cliente_TMP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estadisticos_Ventas_Cliente_TMP> Estadisticos_Ventas_Cliente_TMP1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gastos_Asignacion_Deudores> Gastos_Asignacion_Deudores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grupo_Persona> Grupo_Persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grupo_Persona_Detalle> Grupo_Persona_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historico_Produccion> Historico_Produccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historico_Produccion> Historico_Produccion1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Homologacion_Articulos> Homologacion_Articulos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Homologacion_Modelos> Homologacion_Modelos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ks_Pedido> ks_Pedido { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ks_Pedido_Entrega> ks_Pedido_Entrega { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Modelo> Modeloes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Modelo_Producto_Enc> Modelo_Producto_Enc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orden_Produccion> Orden_Produccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Periodos_Siguientes_Sel> Periodos_Siguientes_Sel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proveedor_Iva> Proveedor_Iva { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cc_Proceso_Pago> cc_Proceso_Pago { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cc_Proceso_Pago> cc_Proceso_Pago1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cp_Proceso_Contabilidad> cp_Proceso_Contabilidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cp_Proceso_Pago> cp_Proceso_Pago { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cp_Proceso_Pago> cp_Proceso_Pago1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Persona_Relacion> Persona_Relacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos_Conceptos_Cliente> Productos_Conceptos_Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proveedor> Proveedors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receta> Recetas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relacion_Caja_Cajero> Relacion_Caja_Cajero { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relacion_Cajero_Almacen> Relacion_Cajero_Almacen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Revision_Calidad> Revision_Calidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salida_Almacen> Salida_Almacen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Taller_Calculo_CP> Taller_Calculo_CP { get; set; }

        public virtual Usuario Usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario_Tipo_Cliente> Usuario_Tipo_Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vendedor> Vendedors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja> Venta_Caja { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja> Venta_Caja1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja> Venta_Caja2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja> Venta_Caja3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja_Apertura> Venta_Caja_Apertura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja_Cierre> Venta_Caja_Cierre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Caja_Cierre> Venta_Caja_Cierre1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Viaticos_Solicitud> Viaticos_Solicitud { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Viaticos_Solicitud> Viaticos_Solicitud1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Control_Procesos> Control_Procesos1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
