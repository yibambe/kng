namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transaccion_Programa_Auxiliar
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Programa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Des_Auxiliar { get; set; }

        public int Numero_Orden { get; set; }
    }
}
