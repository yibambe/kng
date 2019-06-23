namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contabilidad")]
    public partial class Contabilidad
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cuenta { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal Saldo_Inicial { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal Saldo_Actual { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal Cargos { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal Abonos { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal Cargos_Acum { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal Abonos_Acum { get; set; }

        public int? Periodo { get; set; }

        public DateTime? Fecha { get; set; }
    }
}
