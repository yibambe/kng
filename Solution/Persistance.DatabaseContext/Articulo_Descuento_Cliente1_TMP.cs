namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Articulo_Descuento_Cliente1_TMP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int? Numero_Cliente { get; set; }

        public int? Clas_Producto { get; set; }

        public int? Clas_Tipo { get; set; }

        public int? Clas_Concepto { get; set; }

        public int? Numero_Concepto { get; set; }

        public int? Orden { get; set; }

        public decimal? Descuento { get; set; }

        public DateTime? Fecha_Vigencia { get; set; }

        public DateTime? Fin_Vigencia { get; set; }

        public decimal? Hasta { get; set; }

        public int? Familia { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cotizacion { get; set; }
    }
}
