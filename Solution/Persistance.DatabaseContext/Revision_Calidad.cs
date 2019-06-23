namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Revision_Calidad
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Revision { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Fecha_Revision { get; set; }

        public int Numero_Orden { get; set; }

        public int Numero_Entrega { get; set; }

        public int Numero_Diagnostico { get; set; }

        public int Familia_Diagnostico { get; set; }

        public int Numero_Causa { get; set; }

        public int Familia_Causa { get; set; }

        public int Usuario { get; set; }

        [StringLength(250)]
        public string Observaciones { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Orden_Produccion Orden_Produccion { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
