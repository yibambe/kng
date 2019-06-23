namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cuentas_Pagar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cuentas_Pagar()
        {
            cp_Pagos_Detalle = new HashSet<cp_Pagos_Detalle>();
            cp_Proceso_Pago = new HashSet<cp_Proceso_Pago>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int? Numero_Proveedor { get; set; }

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

        public int? Usuario { get; set; }

        public int? Moneda { get; set; }

        public int? Num_Banco { get; set; }

        public int? Num_Cuenta { get; set; }

        public int? Num_Caja { get; set; }

        public int? Tipo_Persona { get; set; }

        public int? Clas_IVA { get; set; }

        public int? Clas_Gasto { get; set; }

        public int? Familia { get; set; }

        public int? Familia_Moneda { get; set; }

        public int? Familia_IVA { get; set; }

        public int? Numero_Movimiento_Banco { get; set; }

        public int? Numero_Movimiento_Caja { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public int? Clas_Centro_Costo { get; set; }

        public int? Clas_CC { get; set; }

        public decimal? TC_Mes { get; set; }

        public short? Estatus { get; set; }

        public DateTime? Fecha_Eliminacion { get; set; }

        public int? Clas_Tipo_Gasto { get; set; }

        public int? Prorrateo { get; set; }

        public int? Anticipo { get; set; }

        [StringLength(50)]
        public string Referencia_Texto { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        [StringLength(250)]
        public string Numero_CProyecto { get; set; }

        public int? Proviene { get; set; }

        public int? Clas_Concepto_Cancelacion { get; set; }

        public int? Familia_Clas_Concep_Cancelacion { get; set; }

        public int? Usuario_Cancelacion { get; set; }

        public DateTime? Fecha_Revision { get; set; }

        public int? Clas_Pantalla { get; set; }

        [StringLength(4000)]
        public string Folio_Fiscal { get; set; }

        public int? TipoPago { get; set; }

        public int? Poliza_Manual { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cp_Pagos_Detalle> cp_Pagos_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cp_Proceso_Pago> cp_Proceso_Pago { get; set; }

        public virtual Cuentas_Pagar_Conceptos Cuentas_Pagar_Conceptos { get; set; }

        public virtual Proveedor Proveedor { get; set; }
    }
}
