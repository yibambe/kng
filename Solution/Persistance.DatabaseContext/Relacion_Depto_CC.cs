namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Relacion_Depto_CC
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Depto { get; set; }

        public int? Cuenta_CC { get; set; }

        public int? Cuenta_Gasto { get; set; }

        public int? Familia_CC { get; set; }

        public int? Familia_Depto { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }
    }
}
