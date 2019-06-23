namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Fondo")]
    public partial class Fondo
    {
        [Key]
        public int Id_Fondo { get; set; }

        [Required]
        [StringLength(50)]
        public string Fondo_Mensaje { get; set; }
    }
}
