namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contabilidad_Polizas_Importadas
    {
        [Key]
        [Column(Order = 0)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime Fecha_Actual { get; set; }

        public DateTime? Fecha_Poliza { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(80)]
        public string UUID { get; set; }
    }
}
