namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Almacen_Existencia_TMP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Usuario { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Almacen { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_TProducto { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Producto { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_TConcepto { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Concepto { get; set; }

        public decimal? Total_Existencia { get; set; }

        public decimal? Total_Apartado { get; set; }

        public int? UM { get; set; }

        [StringLength(100)]
        public string Parte { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Familia { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Familia_Almacen { get; set; }

        public decimal? Costo { get; set; }

        public decimal? Cantidad_Recibida_Base { get; set; }

        public decimal? Cantidad_Entregada_Base { get; set; }

        public decimal? Cantidad_Apartada_Base { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public decimal? Ultimo_Costo { get; set; }

        public int? Moneda { get; set; }
    }
}
