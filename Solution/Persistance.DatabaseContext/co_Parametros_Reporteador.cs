namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class co_Parametros_Reporteador
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int? Clas_Costo { get; set; }

        public int? Clas_Costo_Base { get; set; }

        public int? Clas_Gasto { get; set; }

        public int? Clas_Gasto_Base { get; set; }

        public int? Clas_Ingreso { get; set; }

        public int? Clas_Ingreso_Base { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Familia { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }

        public virtual Clasificacion Clasificacion3 { get; set; }

        public virtual Clasificacion Clasificacion4 { get; set; }

        public virtual Clasificacion Clasificacion5 { get; set; }
    }
}
