namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Entrega_Almacen_Prod_Motivos
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
        public int Numero_Motivo { get; set; }

        public int Familia_Motivo { get; set; }

        public decimal Cantidad { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Entrega_Almacen_Prod Entrega_Almacen_Prod { get; set; }
    }
}
