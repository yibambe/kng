namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FE_NO_Relacion_CFDI_CxC
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smalldatetime")]
        public DateTime Fecha_Reporte { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Usuario { get; set; }

        public int? Tipo_Documento { get; set; }

        public int? Serie { get; set; }

        public int? Folio { get; set; }

        public int? Numero_CxC { get; set; }

        [StringLength(2500)]
        public string Carpeta { get; set; }

        public int? Numero_Poliza { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Poliza { get; set; }

        [StringLength(250)]
        public string Concepto_Poliza { get; set; }

        public decimal? Importe { get; set; }

        [StringLength(4000)]
        public string Folio_Fiscal { get; set; }

        [StringLength(4000)]
        public string Mensaje { get; set; }
    }
}
