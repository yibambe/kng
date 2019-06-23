namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FE_NO_Relacion_CFDI_CxP
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

        [StringLength(50)]
        public string Folio { get; set; }

        [StringLength(10)]
        public string Fecha_Factura { get; set; }

        public int? Numero_CxP { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(36)]
        public string RFC_Proveedor { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(300)]
        public string Nombre_Proveedor { get; set; }

        [StringLength(2500)]
        public string Carpeta { get; set; }

        public decimal? Importe { get; set; }

        [StringLength(4000)]
        public string Folio_Fiscal { get; set; }

        [StringLength(4000)]
        public string Mensaje { get; set; }
    }
}
