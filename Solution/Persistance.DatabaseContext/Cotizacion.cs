namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cotizacion")]
    public partial class Cotizacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cotizacion()
        {
            Cotizacion_Art_Descuentos = new HashSet<Cotizacion_Art_Descuentos>();
            Cotizacion_Fac_Descuentos = new HashSet<Cotizacion_Fac_Descuentos>();
            Cotizacion_MatRecibido = new HashSet<Cotizacion_MatRecibido>();
            Cotizacion_Programada = new HashSet<Cotizacion_Programada>();
            Cotizacion_Detalle = new HashSet<Cotizacion_Detalle>();
            Registro_Pago = new HashSet<Registro_Pago>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int? Estatus { get; set; }

        public DateTime? Fecha { get; set; }

        public int Numero_Cliente { get; set; }

        public int? Numero_Usuario { get; set; }

        public int? Numero_Responsable { get; set; }

        [StringLength(100)]
        public string Nombre_Proyecto { get; set; }

        public int Moneda { get; set; }

        public DateTime? Fecha_Entrega { get; set; }

        public int? Numero_Contacto { get; set; }

        [StringLength(4000)]
        public string Observaciones { get; set; }

        public int Numero_Pago { get; set; }

        public int Clas_Periodo_Pago { get; set; }

        public short Comision_Calculada { get; set; }

        public int? Tipo_Documento { get; set; }

        public DateTime Fecha_Vencimiento { get; set; }

        public int Clas_IVA { get; set; }

        public short? Familia_Estatus { get; set; }

        public short? Familia_Moneda { get; set; }

        public short? Familia_Clas_Periodo_Pago { get; set; }

        public short? Familia_Tipo_Documento { get; set; }

        public int? Relacion_Tipo_Documento { get; set; }

        public int? Moneda_Factura { get; set; }

        [StringLength(4000)]
        public string Observaciones2 { get; set; }

        public int? Autoriza { get; set; }

        public int? Concepto_Apartado { get; set; }

        public int? Num_Concepto { get; set; }

        [StringLength(30)]
        public string Num_Referencia { get; set; }

        public int? Numero_Domicilio { get; set; }

        public int? Clas_Almacen { get; set; }

        public byte? Credito { get; set; }

        public int? Ciclo_Facturacion { get; set; }

        public int? Clas_Sucursal { get; set; }

        public int? Familia_Sucursal { get; set; }

        public byte? chkContado { get; set; }

        public byte? Entrega_Directa { get; set; }

        public int? Lista_Precio { get; set; }

        public int? Lista_Precio_Real { get; set; }

        public int? Clas_Dato_Pago { get; set; }

        [StringLength(20)]
        public string Dato_Pago { get; set; }

        public int? Familia_Clas_Dato_Pago { get; set; }

        public byte? chkTransporte { get; set; }

        public byte? Total_Transporte { get; set; }

        public int? FolioSucursal { get; set; }

        public int? Numero_Devolucion { get; set; }

        public virtual Cliente Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion_Art_Descuentos> Cotizacion_Art_Descuentos { get; set; }

        public virtual Cotizacion_Autorizar Cotizacion_Autorizar { get; set; }

        public virtual Empresa Empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion_Fac_Descuentos> Cotizacion_Fac_Descuentos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion_MatRecibido> Cotizacion_MatRecibido { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Persona Persona1 { get; set; }

        public virtual Persona Persona2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion_Programada> Cotizacion_Programada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotizacion_Detalle> Cotizacion_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registro_Pago> Registro_Pago { get; set; }
    }
}
