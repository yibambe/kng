namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            Cliente_Credito = new HashSet<Cliente_Credito>();
            Cliente_Departamento = new HashSet<Cliente_Departamento>();
            Cliente_Vendedor = new HashSet<Cliente_Vendedor>();
            Condiciones_Facturacion_Pago = new HashSet<Condiciones_Facturacion_Pago>();
            Condiciones_Facturacion_Revision = new HashSet<Condiciones_Facturacion_Revision>();
            Contactoes = new HashSet<Contacto>();
            Cotizacions = new HashSet<Cotizacion>();
            Cotizacion_Simple = new HashSet<Cotizacion_Simple>();
            Cuentas_Cobrar = new HashSet<Cuentas_Cobrar>();
            Producto_Cliente = new HashSet<Producto_Cliente>();
            Relacion_Cliente_Proveedor = new HashSet<Relacion_Cliente_Proveedor>();
            Personas = new HashSet<Persona>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_persona { get; set; }

        public int? Clasificacion_cliente { get; set; }

        public DateTime? Fecha_alta { get; set; }

        public int? Estatus { get; set; }

        [StringLength(50)]
        public string Giro { get; set; }

        public int? Cont_Clas_Cliente { get; set; }

        public int? Cont_Clas_Cliente_Pasivo { get; set; }

        public int? Periodo_Pago { get; set; }

        public int? Clas_Periodo_Pago { get; set; }

        public int? Cont_Clas_Cliente_Ingresos { get; set; }

        public int? Cont_Clas_Cliente_Ingresos2 { get; set; }

        public int? Clas_Sucursal { get; set; }

        public int? Familia_Sucursal { get; set; }

        public int? Dias_Traslado { get; set; }

        public int? Forma_Pago { get; set; }

        public int? Clas_Zona { get; set; }

        public int? Lista_Precio { get; set; }

        public int? Familia_Zona { get; set; }

        public int? Clas_Dato_Pago { get; set; }

        [StringLength(20)]
        public string Dato_Pago { get; set; }

        public int? Familia_Clas_Dato_Pago { get; set; }

        public byte? Adenda { get; set; }

        [StringLength(50)]
        public string Numero_RegTributario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente_Credito> Cliente_Credito { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente_Departamento> Cliente_Departamento { get; set; }

        public virtual Cliente_Referencia Cliente_Referencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente_Vendedor> Cliente_Vendedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Condiciones_Facturacion_Pago> Condiciones_Facturacion_Pago { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Condiciones_Facturacion_Revision> Condiciones_Facturacion_Revision { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contacto> Contactoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion> Cotizacions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion_Simple> Cotizacion_Simple { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cuentas_Cobrar> Cuentas_Cobrar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto_Cliente> Producto_Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relacion_Cliente_Proveedor> Relacion_Cliente_Proveedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
