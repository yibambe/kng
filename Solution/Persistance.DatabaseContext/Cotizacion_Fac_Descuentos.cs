namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cotizacion_Fac_Descuentos
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cotizacion { get; set; }

        [StringLength(80)]
        public string Des_Concepto_Descuento { get; set; }

        public decimal? Monto_Descuento { get; set; }

        public decimal? Porcentaje { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Orden_Descuento { get; set; }

        public byte? Tipo { get; set; }

        public int? Numero_Orden { get; set; }

        public virtual Cotizacion Cotizacion { get; set; }
    }
}
