namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Activo_Fijo_Depreciacion
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_EMpresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Detalle { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Activo_Fijo { get; set; }

        public DateTime? Fecha_Depreciacion { get; set; }

        public decimal? Importe_Anterior_Fiscal { get; set; }

        public int? Pocentaje_Fiscal { get; set; }

        public decimal? Importe_Descuento_Fiscal { get; set; }

        public decimal? Importe_total_Fiscal { get; set; }

        public decimal Importe_Anterior_Contable { get; set; }

        public int Porcentaje_Contable { get; set; }

        public decimal Importe_Descuento_Contable { get; set; }

        public decimal Importe_total_Contable { get; set; }

        public virtual Activo_Fijo Activo_Fijo { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
