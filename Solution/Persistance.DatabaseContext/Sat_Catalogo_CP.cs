namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sat_Catalogo_CP
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string C_Codigo_Postal { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string c_Estado { get; set; }

        [StringLength(100)]
        public string c_Municipio { get; set; }

        [StringLength(50)]
        public string c_Localidad { get; set; }
    }
}
