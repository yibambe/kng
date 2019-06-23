namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Produccion_Almacen_Detalle
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_PA { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Concepto_PA { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Partida { get; set; }

        public int Clas_TProducto { get; set; }

        public int Clas_Producto { get; set; }

        public int Clas_TConcepto { get; set; }

        [Required]
        [StringLength(10)]
        public string Clas_Concepto { get; set; }

        public decimal? Cantidad { get; set; }

        public decimal? Costo { get; set; }

        public decimal? Cantidad_Entregada { get; set; }

        public int Familia_Concepto { get; set; }

        public int Familia_Concepto_ID { get; set; }

        public virtual Produccion_Almacen Produccion_Almacen { get; set; }
    }
}
