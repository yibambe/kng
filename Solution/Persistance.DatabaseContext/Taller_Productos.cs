namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Taller_Productos
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Producto { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Concepto { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Numero_Padre { get; set; }

        public int Numero_Detalle { get; set; }

        public int Familia_Prod { get; set; }

        public int Familia_Caract { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }
    }
}
