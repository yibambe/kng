namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConceptoInterno")]
    public partial class ConceptoInterno
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Clave { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 1)]
        public int c { get; set; }

        [StringLength(5)]
        public string TipoAfectacion { get; set; }

        public int? Cargo { get; set; }

        public int? Abono { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool ControlFolioCh { get; set; }
    }
}
