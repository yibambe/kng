namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cuentas_Cobrar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cuentas_Cobrar()
        {
            cc_Pagos_Detalle = new HashSet<cc_Pagos_Detalle>();
            cc_Proceso_Pago = new HashSet<cc_Proceso_Pago>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int? Numero_Cliente { get; set; }

        public int? Numero_Concepto { get; set; }

        [StringLength(50)]
        public string Documento { get; set; }

        [StringLength(50)]
        public string Numero_Referencia { get; set; }

        public DateTime? Fecha_Aplicacion { get; set; }

        public DateTime? Fecha_Vencimiento { get; set; }

        public decimal? Monto { get; set; }

        public decimal? Cargo { get; set; }

        public decimal? Abono { get; set; }

        public decimal? Saldo { get; set; }

        [StringLength(50)]
        public string Numero_Factura { get; set; }

        public int? Usuario { get; set; }

        public int? Moneda { get; set; }

        public int? Num_Banco { get; set; }

        public int? Num_Cuenta { get; set; }

        public int? Num_Caja { get; set; }

        public int? Clas_Tipo_Documento { get; set; }

        public int? Clas_IVA { get; set; }

        public short? Familia_Tipo_Documento { get; set; }

        public short? Tipo_Documento_CC { get; set; }

        public short Familia_Moneda { get; set; }

        public int? Numero_Movimiento_Banco { get; set; }

        public int? Numero_Movimiento_Caja { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public decimal? TC_Mes { get; set; }

        public short? Estatus { get; set; }

        public DateTime? Fecha_Eliminacion { get; set; }

        public int? Anticipo { get; set; }

        public byte? Credito { get; set; }

        public int? Clas_Concepto_Cancelacion { get; set; }

        public int? Familia_Clas_Concep_Cancelacion { get; set; }

        public int? Usuario_Cancelacion { get; set; }

        public int? Clas_Pantalla { get; set; }

        [StringLength(4000)]
        public string Folio_Fiscal { get; set; }

        public int? Poliza_Manual { get; set; }

        public int? Clas_FPago { get; set; }

        [StringLength(20)]
        public string Forma_Pago { get; set; }

        [StringLength(100)]
        public string Folio_Fiscal_CRP { get; set; }

        public int? Clas_Sucursal { get; set; }

        public int? Serie { get; set; }

        public int? Serie_Numero { get; set; }

        public int? ESTATUS_SAT { get; set; }

        public int? FP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cc_Pagos_Detalle> cc_Pagos_Detalle { get; set; }

        public virtual Cliente Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cc_Proceso_Pago> cc_Proceso_Pago { get; set; }

        public virtual Cuentas_Cobrar_Conceptos Cuentas_Cobrar_Conceptos { get; set; }
    }
}
