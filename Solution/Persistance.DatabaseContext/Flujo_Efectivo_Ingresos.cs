namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Flujo_Efectivo_Ingresos
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_FE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Numero_CC { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime Fecha_Estimada { get; set; }

        public decimal? Monto { get; set; }
    }
}
