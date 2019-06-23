namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OP_Simulacion_Detalle_Resumen
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Simulacion { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Partida { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Producto_Det { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Concepto_Det { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal Cantidad { get; set; }

        public int? Clas_Almacen { get; set; }

        public int? Num_Requisicion { get; set; }

        public int? Familia_Det { get; set; }

        public int? Familia_Almacen { get; set; }

        public short? Procesado { get; set; }

        public decimal? Cantidad_Entregada { get; set; }

        public int? Numero { get; set; }
    }
}
