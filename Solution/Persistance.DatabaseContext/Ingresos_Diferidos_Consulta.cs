namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ingresos_Diferidos_Consulta
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
        public int Numero_ID { get; set; }

        public DateTime? Fecha_Consulta { get; set; }

        public int? Meses_Diferidos { get; set; }

        public int? Meses_Ejercicio { get; set; }

        public decimal? Acumulado { get; set; }

        public DateTime? Fecha_Acumulado { get; set; }

        public decimal? Ejercicio { get; set; }
    }
}
