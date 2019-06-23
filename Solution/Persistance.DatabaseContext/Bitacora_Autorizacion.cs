namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bitacora_Autorizacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int? Numero_Persona { get; set; }

        [Column(TypeName = "text")]
        public string Comentario { get; set; }

        [StringLength(100)]
        public string Movimiento { get; set; }

        [StringLength(100)]
        public string Modulo { get; set; }

        public int? Registro { get; set; }

        public DateTime? Fecha { get; set; }
    }
}
