namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Factura_Email
    {
        [Key]
        public int IDFactura_Email { get; set; }

        [Required]
        public string EMAIL { get; set; }

        public int EMPRESA { get; set; }

        [StringLength(50)]
        public string RFC { get; set; }

        [Required]
        public string BASEDATOS { get; set; }

        public string RUTA { get; set; }

        public string D1 { get; set; }

        public DateTime FECHAALTA { get; set; }

        public DateTime FECHAMODIFICACION { get; set; }
    }
}
