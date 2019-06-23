namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Devolucion_Cliente_Detalle
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Devolucion { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Secuencia { get; set; }

        public int Clas_Producto { get; set; }

        public int Clas_Concepto { get; set; }

        public int Familia { get; set; }

        public decimal Cantidad { get; set; }

        public decimal Precio_Unitario { get; set; }

        public decimal? Cantidad_Ingresada { get; set; }

        public int? Clas_Causa { get; set; }

        public int? Familia_Causa { get; set; }

        public decimal? Costo { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }
    }
}
