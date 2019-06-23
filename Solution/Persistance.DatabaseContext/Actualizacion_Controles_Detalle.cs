namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Actualizacion_Controles_Detalle
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Orden { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public DateTime? Fecha_Inicio { get; set; }

        public DateTime? Fecha_Conclusion { get; set; }

        public int? Numero_Responsable { get; set; }

        [StringLength(250)]
        public string Observaciones { get; set; }

        [StringLength(20)]
        public string Tiempo { get; set; }

        public virtual Control_Procesos Control_Procesos { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
