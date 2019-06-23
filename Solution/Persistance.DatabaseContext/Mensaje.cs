namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mensaje")]
    public partial class Mensaje
    {
        [Key]
        public int Id_Mensaje { get; set; }

        [Required]
        [StringLength(100)]
        public string Mensaje_Texto { get; set; }

        [Required]
        [StringLength(50)]
        public string Fuente { get; set; }

        public int Tamaño { get; set; }

        [Required]
        [StringLength(50)]
        public string Color { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha_Inicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha_Vencimiento { get; set; }

        public int Id_Fondo { get; set; }

        public int Numero_Empresa { get; set; }
    }
}
