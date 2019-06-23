namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orden_Compras_Factura_Multiple_Det
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Relacion { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte Tipo { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte Numero_Tipo { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte Tipo1 { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Producto { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Concepto { get; set; }

        public decimal? Cantidad { get; set; }

        public decimal? Precio { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Familia_Concepto { get; set; }

        public int? Clas_Almacen { get; set; }

        public int? Partida { get; set; }

        public int? Numero_Entrada { get; set; }
    }
}
