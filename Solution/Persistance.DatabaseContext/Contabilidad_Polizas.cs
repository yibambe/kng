namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contabilidad_Polizas
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Numero_Poliza { get; set; }

        public int Tipo_Poliza { get; set; }

        public DateTime Fecha { get; set; }

        public int Numero_Cuenta { get; set; }

        [StringLength(4000)]
        public string Concepto { get; set; }

        public decimal? Debe { get; set; }

        public decimal? Haber { get; set; }

        public int Numero_Usuario { get; set; }

        public int Periodo { get; set; }

        public decimal? Numero_Manual { get; set; }

        public int Clas_Moneda_Destino { get; set; }

        public decimal Numero_Tipo_Cambio { get; set; }

        public int Familia { get; set; }

        [StringLength(4000)]
        public string Titulo { get; set; }

        public int? Bandera { get; set; }

        [StringLength(4000)]
        public string Folio_Fiscal { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
