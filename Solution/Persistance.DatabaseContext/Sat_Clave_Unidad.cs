namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sat_Clave_Unidad
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string c_ClaveUnidad { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(4000)]
        public string Descripción { get; set; }

        public DateTime? Fecha_Vigencia { get; set; }

        public DateTime? Fecha_Fin_Vigencia { get; set; }

        [StringLength(250)]
        public string Simbolo { get; set; }
    }
}
