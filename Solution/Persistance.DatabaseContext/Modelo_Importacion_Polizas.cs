namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Modelo_Importacion_Polizas
    {
        [StringLength(4)]
        public string Compania { get; set; }

        [StringLength(250)]
        public string Nombre_Compania { get; set; }

        [StringLength(100)]
        public string Tipo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        [StringLength(250)]
        public string Concepto { get; set; }

        [StringLength(30)]
        public string Cuenta { get; set; }

        public decimal? Debe { get; set; }

        public decimal? Haber { get; set; }

        [StringLength(80)]
        public string Titulo { get; set; }

        public int? Proyecto { get; set; }

        [StringLength(120)]
        public string Cliente { get; set; }

        [StringLength(4000)]
        public string Folio_Fiscal { get; set; }

        [StringLength(250)]
        public string Comentarios { get; set; }

        public int ID { get; set; }

        public int? Usuario { get; set; }
    }
}
