namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sat_Catalogo_prod_Serv
    {
        [Key]
        [StringLength(20)]
        public string c_ClaveProdServ { get; set; }

        [Required]
        [StringLength(2000)]
        public string Descripcion { get; set; }

        public DateTime Fecha_Ini { get; set; }

        public DateTime? Fecha_Fin { get; set; }

        public byte? Incluir_Iva_Traslado { get; set; }

        public byte? Incluir_Ieps_Traslado { get; set; }
    }
}
