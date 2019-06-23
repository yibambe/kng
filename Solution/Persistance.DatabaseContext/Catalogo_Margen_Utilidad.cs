namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Catalogo_Margen_Utilidad
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Producto { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Concepto { get; set; }

        public decimal Costo { get; set; }

        public decimal IVA { get; set; }

        public decimal IEPS { get; set; }

        public decimal Precio { get; set; }

        public decimal Precio_Competencia1 { get; set; }

        public decimal Precio_Competencia2 { get; set; }

        public decimal Utilidad1 { get; set; }

        public decimal Utilidad2 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Familia_Concepto { get; set; }

        public decimal? Precio_Catalogo { get; set; }
    }
}
