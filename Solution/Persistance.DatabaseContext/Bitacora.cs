namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bitacora")]
    public partial class Bitacora
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Numero_Empresa { get; set; }

        public int Num_Persona { get; set; }

        [Required]
        [StringLength(20)]
        public string Programa { get; set; }

        public int Accion { get; set; }

        [Required]
        [StringLength(1100)]
        public string Comentario { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime Hora { get; set; }

        public decimal? Importe { get; set; }
    }
}
