namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cuentas_Cobrar_Global
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Usuario { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cliente { get; set; }

        public int? Numero_Concepto { get; set; }

        [StringLength(50)]
        public string Numero_Referencia { get; set; }

        [StringLength(50)]
        public string Documento { get; set; }

        public DateTime? Fecha_Aplicacion { get; set; }

        public decimal? Monto { get; set; }

        public decimal? Abono { get; set; }

        public decimal? Saldo { get; set; }

        public decimal? Abonado { get; set; }

        public int? Moneda { get; set; }

        public int? Num_Banco { get; set; }

        public int? Num_Cuenta { get; set; }

        public int? Clas_Tipo_Documento { get; set; }

        public short? Tipo_Documento_CC { get; set; }

        public int? Num_Caja { get; set; }

        public int? IVA { get; set; }

        public int? Auxiliar { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public int? Nota_Credito { get; set; }

        public int? Anticipo { get; set; }

        public int? Num_Anticipo { get; set; }

        public decimal? Monto_Anticipo { get; set; }

        [StringLength(50)]
        public string Cuenta_Banco { get; set; }

        public decimal? Tipo_Cambio_MES { get; set; }
    }
}
