namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Historico_Prod_Detalle
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Historico { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Partida { get; set; }

        public int Numero_Modelo { get; set; }

        public int Clas_Producto { get; set; }

        public int Clas_Concepto { get; set; }

        public int Familia_Concepto { get; set; }

        public int Clas_UM { get; set; }

        public int Familia_UM { get; set; }

        public decimal? Cantidad { get; set; }

        public decimal? Cantidad_Entregada { get; set; }

        public decimal? Precio_Unitario { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }

        public virtual Historico_Produccion Historico_Produccion { get; set; }

        public virtual Modelo Modelo { get; set; }
    }
}
