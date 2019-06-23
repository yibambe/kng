namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Gastos_Asignacion_Deudores
    {
        [Key]
        public int Numero { get; set; }

        public int? Numero_Empresa { get; set; }

        public int? Numero_Persona { get; set; }

        [StringLength(100)]
        public string Motivo { get; set; }

        public decimal? Importe { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Comprobacion { get; set; }

        public int? Estatus { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Cancelacion { get; set; }

        public int? NumeroPersona_Cancelo { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
