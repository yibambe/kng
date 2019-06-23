namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Administracion_Recursos_Detalle
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int Numero_Admon { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Numero_Producto { get; set; }

        public int Familia_Producto { get; set; }

        public decimal Cantidad_Batch { get; set; }

        [StringLength(8)]
        public string Tiempo_Batch { get; set; }

        public int Numero_UMedida { get; set; }

        public int Familia_UMedida { get; set; }

        public virtual Administracion_Recursos Administracion_Recursos { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }
    }
}
