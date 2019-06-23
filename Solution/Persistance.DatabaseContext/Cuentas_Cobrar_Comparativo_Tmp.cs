namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cuentas_Cobrar_Comparativo_Tmp
    {
        public int? Numero_Empresa { get; set; }

        public int? Numero_Usuario { get; set; }

        public int? Numero { get; set; }

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

        public int? Moneda { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Familia_Moneda { get; set; }

        public decimal? Saldo_Inicial { get; set; }

        public decimal? Saldo_Inicial_Auxiliar { get; set; }

        public decimal? Saldo_Final_Cliente { get; set; }

        public decimal? Saldo_Final_Auxiliar { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Cuenta_Contable { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Cuenta_Contable_Anticipo { get; set; }

        public decimal? Saldo_Anticipo_Inicial { get; set; }

        public decimal? Saldo_Anticipo_Final { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Familia { get; set; }
    }
}
