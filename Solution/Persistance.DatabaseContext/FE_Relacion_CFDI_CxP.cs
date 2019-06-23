namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FE_Relacion_CFDI_CxP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [StringLength(50)]
        public string Folio { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smalldatetime")]
        public DateTime Fecha_Relacion { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_CxP { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Proveedor { get; set; }

        public int? Numero_Poliza { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Poliza { get; set; }

        [StringLength(250)]
        public string Concepto_Poliza { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal Importe { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(4000)]
        public string Folio_Fiscal { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Usuario { get; set; }
    }
}
