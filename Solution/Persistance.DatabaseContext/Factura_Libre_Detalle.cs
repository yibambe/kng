namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Factura_Libre_Detalle
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Factura_Libre { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Partida { get; set; }

        public int Clas_TProducto { get; set; }

        public int Clas_Producto { get; set; }

        public int Clas_TConcepto { get; set; }

        public int Clas_Concepto { get; set; }

        [StringLength(4000)]
        public string Caracteristicas { get; set; }

        public int Clas_UM { get; set; }

        public decimal Cantidad { get; set; }

        public decimal? Precio { get; set; }

        public decimal? Iva { get; set; }

        public int Clas_Iva { get; set; }

        public int Familia_UM { get; set; }

        public int Familia_Iva { get; set; }
    }
}
