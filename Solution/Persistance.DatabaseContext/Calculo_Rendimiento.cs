namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Calculo_Rendimiento
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Orden { get; set; }

        public decimal Batches_Planeados { get; set; }

        public decimal Batches_Reales { get; set; }

        public decimal? Reproceso_Real { get; set; }

        public decimal? Producto_Bueno_Real { get; set; }

        public decimal? Reproceso_Utilizado { get; set; }

        public decimal? Producto_Real { get; set; }

        public virtual Orden_Produccion Orden_Produccion { get; set; }
    }
}
