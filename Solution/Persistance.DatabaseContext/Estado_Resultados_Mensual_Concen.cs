namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Estado_Resultados_Mensual_Concen
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Usuario { get; set; }

        [StringLength(80)]
        public string Numero_Tipo_Cuenta { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cuenta { get; set; }

        [StringLength(80)]
        public string Des_Cuenta { get; set; }

        public decimal? Total_Mes { get; set; }

        public decimal? Acumulado { get; set; }

        public decimal? Orden { get; set; }

        public int? Familia { get; set; }
    }
}
