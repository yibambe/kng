namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Activos_Fijos_Conceptos
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Clas_Concepto { get; set; }

        public int Clas_Porcentaje { get; set; }

        public decimal Porcentaje { get; set; }

        public int Meses_Depreciacion { get; set; }

        public decimal Monto_Min { get; set; }

        public int Familia_Porcentaje { get; set; }
    }
}
