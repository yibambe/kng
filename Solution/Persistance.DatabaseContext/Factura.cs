namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Factura")]
    public partial class Factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Factura()
        {
            Devolucion_Cliente = new HashSet<Devolucion_Cliente>();
            Factura_Comisionistas = new HashSet<Factura_Comisionistas>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Numero_Cliente { get; set; }

        public int Moneda { get; set; }

        public DateTime? Fecha_Emision { get; set; }

        public DateTime? Fecha_Revision { get; set; }

        public DateTime? Fecha_Pago { get; set; }

        public int Persona_Factura { get; set; }

        public int? Numero_Factura { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Descuento { get; set; }

        public decimal Iva { get; set; }

        public decimal Total { get; set; }

        public DateTime? Fecha_Pagada { get; set; }

        [StringLength(1020)]
        public string Importe_Letra { get; set; }

        public int? Impresion { get; set; }

        [StringLength(150)]
        public string Nombre_Proyecto { get; set; }

        public DateTime Fecha_Cotizacion { get; set; }

        public int? Estatus { get; set; }

        public int? Tipo_Documento { get; set; }

        public short? Familia_Clas_Moneda { get; set; }

        public short? Familia_Clas_Estatus { get; set; }

        public short? Familia_Tipo_Documento { get; set; }

        public bool Contabilizada { get; set; }

        public short? Tipo { get; set; }

        public DateTime? Fecha_Cancelacion { get; set; }

        public int? Usuario { get; set; }

        [StringLength(250)]
        public string Causa { get; set; }

        public int? Tipo_Factura_Relacion { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public byte? Tipo_Condiciones_Financieras { get; set; }

        public byte? Tipo_Factura { get; set; }

        [StringLength(50)]
        public string Numero_Pago { get; set; }

        public DateTime? Fecha_Vencimiento { get; set; }

        public int? Clas_Moneda_Cambio { get; set; }

        public int? Num_Concepto { get; set; }

        [StringLength(250)]
        public string Numero_CProyecto { get; set; }

        public int? Numero_Embarque { get; set; }

        public int? Envio { get; set; }

        public int? Proviene { get; set; }

        [StringLength(30)]
        public string Referencia2 { get; set; }

        [StringLength(30)]
        public string Referencia3 { get; set; }

        public DateTime? Hora_Factura { get; set; }

        public int? Factura_Ticket { get; set; }

        public int? Especial { get; set; }

        public int? Estatus_SAT { get; set; }

        public decimal? HONORARIOS { get; set; }

        public decimal? RET_ISR { get; set; }

        public decimal? RET_IVA { get; set; }

        public decimal? TOTALTOTAL { get; set; }

        [StringLength(800)]
        public string PATH { get; set; }

        public int? Clas_Forma_Pago { get; set; }

        [StringLength(50)]
        public string Forma_Pago { get; set; }

        [StringLength(100)]
        public string Condicion_Pago { get; set; }

        [StringLength(100)]
        public string Metodo_Pago_Sat { get; set; }

        [StringLength(100)]
        public string Clas_Metodo_Pago_Sat { get; set; }

        [StringLength(50)]
        public string Folio_Fiscal { get; set; }

        public int? UsoCFDI { get; set; }

        [StringLength(10)]
        public string Metodo_Pago { get; set; }

        [StringLength(10)]
        public string Nombre_Programa { get; set; }

        public int? Numero_Llave { get; set; }

        public int? Relacion_Anticipo { get; set; }

        public int? Refacturada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Devolucion_Cliente> Devolucion_Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura_Comisionistas> Factura_Comisionistas { get; set; }
    }
}
