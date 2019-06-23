namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empresa")]
    public partial class Empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empresa()
        {
            Activo_Fijo = new HashSet<Activo_Fijo>();
            Activo_Fijo_Depreciacion = new HashSet<Activo_Fijo_Depreciacion>();
            Autoriza_Perfil_Pantalla = new HashSet<Autoriza_Perfil_Pantalla>();
            Banco_Formato_Impresion = new HashSet<Banco_Formato_Impresion>();
            Bancos = new HashSet<Banco>();
            Bancos_Cuentas_Propias = new HashSet<Bancos_Cuentas_Propias>();
            Bancos_Cuentas_Propias_Facultades = new HashSet<Bancos_Cuentas_Propias_Facultades>();
            Bancos_Cuentas_Terceros = new HashSet<Bancos_Cuentas_Terceros>();
            Bancos_Registro_Movimiento = new HashSet<Bancos_Registro_Movimiento>();
            Cajas = new HashSet<Caja>();
            Caja_Apertura_Dotacion = new HashSet<Caja_Apertura_Dotacion>();
            Caja_Chica = new HashSet<Caja_Chica>();
            Caja_Corte = new HashSet<Caja_Corte>();
            Caja_Detalle = new HashSet<Caja_Detalle>();
            Clasificacions = new HashSet<Clasificacion>();
            Contabilidad_Polizas = new HashSet<Contabilidad_Polizas>();
            Cotizacions = new HashSet<Cotizacion>();
            Cotizacion_Detalle = new HashSet<Cotizacion_Detalle>();
            Cotizacion_Simple = new HashSet<Cotizacion_Simple>();
            Cotizacion_Simple_Detalle = new HashSet<Cotizacion_Simple_Detalle>();
            Articuloes = new HashSet<Articulo>();
            Bancos_Contactos = new HashSet<Bancos_Contactos>();
            Empresa_Horarios = new HashSet<Empresa_Horarios>();
            Facultades_extraordinarias = new HashSet<Facultades_extraordinarias>();
            Familias = new HashSet<Familia>();
            Folios = new HashSet<Folio>();
            Grupo_Persona_Detalle = new HashSet<Grupo_Persona_Detalle>();
            Grupo_Persona = new HashSet<Grupo_Persona>();
            Perfil_usuario = new HashSet<Perfil_usuario>();
            Persona_Relacion = new HashSet<Persona_Relacion>();
            Producto_Cliente = new HashSet<Producto_Cliente>();
            Productoes = new HashSet<Producto>();
            Productos_Conceptos = new HashSet<Productos_Conceptos>();
            Proveedors = new HashSet<Proveedor>();
            Registro_Pago = new HashSet<Registro_Pago>();
            RH_Persona = new HashSet<RH_Persona>();
            Transacciones_Contables = new HashSet<Transacciones_Contables>();
            Viaticos_Solicitud = new HashSet<Viaticos_Solicitud>();
            Perfils = new HashSet<Perfil>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [StringLength(200)]
        public string Nombre { get; set; }

        [StringLength(40)]
        public string Nombre_Corto { get; set; }

        [StringLength(13)]
        public string RFC { get; set; }

        public DateTime? Fecha_alta { get; set; }

        public DateTime? Fecha_contable { get; set; }

        [StringLength(200)]
        public string Domicilio { get; set; }

        [StringLength(50)]
        public string Colonia { get; set; }

        [StringLength(50)]
        public string Delegacion_municipio { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        [StringLength(10)]
        public string Codigo_postal { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Representante_legal { get; set; }

        public short? Status { get; set; }

        public int? Metodo_Costeo { get; set; }

        public byte? Renumeracion_Mov_Contable { get; set; }

        [StringLength(30)]
        public string Descripcion { get; set; }

        public int? Almacen_Transaccion_Automatica { get; set; }

        public byte? Creacion_Poliza { get; set; }

        public int? Almacen_Valida_Articulo { get; set; }

        public int? Longitud_Maxima_Productos { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Costeo { get; set; }

        public decimal? Pronto_Pago_Monto { get; set; }

        public decimal? Puntos_Monto { get; set; }

        public int? Matriz_X { get; set; }

        public int? Matriz_Y { get; set; }

        [StringLength(50)]
        public string Servidor { get; set; }

        [StringLength(10)]
        public string Puerto { get; set; }

        [StringLength(100)]
        public string Mail { get; set; }

        [StringLength(50)]
        public string Contraseña { get; set; }

        [StringLength(2000)]
        public string Texto { get; set; }

        public int? Almacen_EDC_Automatica { get; set; }

        public int? Cia_Felectronica { get; set; }

        public int? Cia_Felectronica_Verificadora { get; set; }

        public int? proceso_salida_almacen { get; set; }

        public byte? Tipo_Validacion_Almacen { get; set; }

        public int? Clas_Pais { get; set; }

        public int? Familia_Pais { get; set; }

        public byte? Modificar_Precio { get; set; }

        public byte? Periodo_Gracia { get; set; }

        public byte? Modificar_Periodo { get; set; }

        public byte? Alta_Cliente_Condiciones { get; set; }

        public byte? Cambio_Fecha { get; set; }

        public byte? Validacion_Existencia_Cero { get; set; }

        public byte? Autentificacion { get; set; }

        public byte? ssl { get; set; }

        public int? Regimen_Fiscal { get; set; }

        public int? Familia_Regimen { get; set; }

        public byte? Expedido_DF { get; set; }

        public byte? Tipo_Factura_Recibo { get; set; }

        public int Tiempo_Mensajes { get; set; }

        public int? Numero_Alterno { get; set; }

        public byte? Venta_Caja { get; set; }

        public byte? Salida_Almacen_Pago { get; set; }

        public byte? Aumento_Automatico_Precio { get; set; }

        [StringLength(10)]
        public string Clave_Empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activo_Fijo> Activo_Fijo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activo_Fijo_Depreciacion> Activo_Fijo_Depreciacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autoriza_Perfil_Pantalla> Autoriza_Perfil_Pantalla { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Banco_Formato_Impresion> Banco_Formato_Impresion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Banco> Bancos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bancos_Cuentas_Propias> Bancos_Cuentas_Propias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bancos_Cuentas_Propias_Facultades> Bancos_Cuentas_Propias_Facultades { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bancos_Cuentas_Terceros> Bancos_Cuentas_Terceros { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bancos_Registro_Movimiento> Bancos_Registro_Movimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja> Cajas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Apertura_Dotacion> Caja_Apertura_Dotacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Chica> Caja_Chica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Corte> Caja_Corte { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Detalle> Caja_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clasificacion> Clasificacions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contabilidad_Polizas> Contabilidad_Polizas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion> Cotizacions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion_Detalle> Cotizacion_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion_Simple> Cotizacion_Simple { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion_Simple_Detalle> Cotizacion_Simple_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Articulo> Articuloes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bancos_Contactos> Bancos_Contactos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empresa_Horarios> Empresa_Horarios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facultades_extraordinarias> Facultades_extraordinarias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Familia> Familias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Folio> Folios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grupo_Persona_Detalle> Grupo_Persona_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grupo_Persona> Grupo_Persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Perfil_usuario> Perfil_usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Persona_Relacion> Persona_Relacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto_Cliente> Producto_Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Productoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos_Conceptos> Productos_Conceptos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proveedor> Proveedors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registro_Pago> Registro_Pago { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RH_Persona> RH_Persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transacciones_Contables> Transacciones_Contables { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Viaticos_Solicitud> Viaticos_Solicitud { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Perfil> Perfils { get; set; }
    }
}
