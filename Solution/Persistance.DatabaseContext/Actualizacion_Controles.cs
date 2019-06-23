namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Actualizacion_Controles
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Orden { get; set; }

        public DateTime? Fecha_Inicio { get; set; }

        public DateTime? Fecha_Termino { get; set; }

        public int Usuario { get; set; }

        public virtual Orden_Produccion Orden_Produccion { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
