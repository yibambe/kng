namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Entrega_Almacen_Prod_Detalle
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Entrega { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Fecha { get; set; }

        public int Numero_Almacen { get; set; }

        public int Familia_Almacen { get; set; }

        public int Numero_Estatus { get; set; }

        public int Familia_Estatus { get; set; }

        public decimal Cantidad { get; set; }

        public decimal? Cantidad_Entregada { get; set; }

        [StringLength(50)]
        public string Num_Lote { get; set; }

        public decimal? Costo { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Entrega_Almacen_Prod Entrega_Almacen_Prod { get; set; }
    }
}
