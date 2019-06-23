namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Articulo_proveedor
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_proveedor { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clasificacion_articulo { get; set; }

        public decimal Costo { get; set; }

        public int? Periodicidad_entrega { get; set; }

        public int? Tiempo_entrega { get; set; }

        public decimal Costo_Credito { get; set; }

        public decimal? Costo_1 { get; set; }

        public decimal? Costo_2 { get; set; }

        public short Familia_Articulo { get; set; }

        public short Familia_Periodicidad { get; set; }

        public virtual Proveedor Proveedor { get; set; }
    }
}
