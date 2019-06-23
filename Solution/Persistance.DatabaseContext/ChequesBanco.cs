namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChequesBanco")]
    public partial class ChequesBanco
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Clave { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string Campo { get; set; }

        public int? Linea { get; set; }

        public int? Columna { get; set; }

        public int? LongitudDatos { get; set; }
    }
}
