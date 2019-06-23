namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contabilidad_Polizas_Paso
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int? Numero_Poliza { get; set; }

        public int? Tipo_Poliza { get; set; }

        public int? Numero_Cuenta { get; set; }

        public DateTime? Fecha { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Concepto { get; set; }

        public decimal? Debe { get; set; }

        public decimal? Haber { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Usuario { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Periodo { get; set; }

        public int? Numero_Manual { get; set; }

        [Key]
        [Column(Order = 4)]
        public string Titulo { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Moneda { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal Tipo_Cambio { get; set; }

        public string Folio_Fiscal { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Consecutivo { get; set; }

        public int? Poliza_Pago { get; set; }
    }
}
