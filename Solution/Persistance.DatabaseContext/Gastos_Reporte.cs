namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Gastos_Reporte
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Estatus { get; set; }

        public DateTime Fecha { get; set; }

        public int Usuario { get; set; }

        [StringLength(2048)]
        public string Cliente { get; set; }

        [StringLength(2048)]
        public string Observaciones { get; set; }
    }
}
