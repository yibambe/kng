namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cp_Proceso_Pago
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Usuario { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Pantalla { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Consecutivo { get; set; }

        public int? Numero_CP { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Proveedor { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tipo_Persona { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Concepto { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string Numero_Referencia { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(100)]
        public string Documento { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime Fecha_Aplicacion { get; set; }

        public decimal? Monto { get; set; }

        public decimal? Abono { get; set; }

        public decimal? Saldo { get; set; }

        public decimal? Importe { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Moneda { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Familia_Moneda { get; set; }

        public int? Numero_Banco { get; set; }

        public int? Numero_Cuenta { get; set; }

        [StringLength(100)]
        public string Des_Cuenta { get; set; }

        public int? Numero_Caja { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_IVA { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Familia_IVA { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public int? Clas_Centro_Costo { get; set; }

        public int? Clas_CC { get; set; }

        public int? Clas_Tipo_Gasto { get; set; }

        public int? Tipo { get; set; }

        public int? Clas_Gasto { get; set; }

        public int? Auxiliar { get; set; }

        public int? Anticipo { get; set; }

        [StringLength(4000)]
        public string Folio_Fiscal { get; set; }

        public int? TipoPago { get; set; }

        public int? Forma_Pago { get; set; }

        [StringLength(20)]
        public string Clas_FPago { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Cuentas_Pagar Cuentas_Pagar { get; set; }

        public virtual Cuentas_Pagar_Conceptos Cuentas_Pagar_Conceptos { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Persona Persona1 { get; set; }
    }
}
