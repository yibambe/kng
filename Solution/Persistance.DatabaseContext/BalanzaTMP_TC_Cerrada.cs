namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BalanzaTMP_TC_Cerrada
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [StringLength(135)]
        public string Cve_Cuenta { get; set; }

        [StringLength(80)]
        public string Descripcion { get; set; }

        public decimal? Saldo_Inicial { get; set; }

        public decimal? Saldo_Actual { get; set; }

        public decimal? Cargos { get; set; }

        public decimal? Abonos { get; set; }

        public int? Nivel { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Usuario { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public decimal? Saldo_Inicial_Año { get; set; }

        public decimal? Cargo_Acumulado { get; set; }

        public decimal? Abono_Acumulado { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Año { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Periodo { get; set; }

        public short? Nivel_Reportado { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Moneda { get; set; }
    }
}
