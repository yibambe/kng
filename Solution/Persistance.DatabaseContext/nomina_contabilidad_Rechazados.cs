namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nomina_contabilidad_Rechazados
    {
        public long? Numero { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string compania { get; set; }

        [StringLength(60)]
        public string nombre_compania { get; set; }

        [StringLength(100)]
        public string tipo { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smalldatetime")]
        public DateTime fecha { get; set; }

        [StringLength(250)]
        public string concepto { get; set; }

        [StringLength(30)]
        public string cuenta { get; set; }

        public decimal? deber { get; set; }

        public decimal? haber { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string poliza_adam { get; set; }

        public short? estatus { get; set; }

        [StringLength(80)]
        public string Titulo { get; set; }

        public int? Proyecto { get; set; }

        [StringLength(150)]
        public string Cliente { get; set; }

        [StringLength(500)]
        public string Comentario { get; set; }
    }
}
