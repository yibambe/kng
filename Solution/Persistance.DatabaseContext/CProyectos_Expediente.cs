namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CProyectos_Expediente
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_CProyecto { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num_Expediente { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Observaciones { get; set; }

        public int Aviso { get; set; }

        public DateTime Fecha_Aviso { get; set; }

        public int Persona_Usuario { get; set; }

        public int? Revisado { get; set; }

        public int? Re { get; set; }

        public virtual CProyecto CProyecto { get; set; }
    }
}
