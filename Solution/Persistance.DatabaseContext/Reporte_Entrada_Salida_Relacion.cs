namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reporte_Entrada_Salida_Relacion
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Usuario { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Almacen { get; set; }

        [StringLength(100)]
        public string Clas_Cve_Almacen { get; set; }

        [StringLength(300)]
        public string Clas_Des_Almacen { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_TProducto { get; set; }

        [StringLength(100)]
        public string Clas_Cve_TProducto { get; set; }

        [StringLength(300)]
        public string Clas_Des_TProducto { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Producto { get; set; }

        [StringLength(100)]
        public string Clas_Cve_Producto { get; set; }

        [StringLength(300)]
        public string Clas_Des_Producto { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_TConcepto { get; set; }

        [StringLength(100)]
        public string Clas_Cve_TConcepto { get; set; }

        [StringLength(300)]
        public string Clas_Des_TConcepto { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Concepto { get; set; }

        [StringLength(100)]
        public string Concepto_Cve { get; set; }

        [StringLength(300)]
        public string Concepto_Des { get; set; }

        public int? Numero_Entrada { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Entrada { get; set; }

        public int? Tipo_Entrada { get; set; }

        [StringLength(300)]
        public string Des_Tipo_Entrada { get; set; }

        public int? Tipo_Docto_Entrada { get; set; }

        [StringLength(300)]
        public string Des_Tipo_Docto_Entrada { get; set; }

        [StringLength(100)]
        public string Numero_Docto_Entrada { get; set; }

        public decimal? Cantidad_Recibida { get; set; }

        public int? Numero_Salida { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Salida { get; set; }

        public decimal? Cantidad_Salida { get; set; }

        public int? Numero_Partida { get; set; }

        public decimal? Saldo { get; set; }

        public decimal? Costo { get; set; }

        public decimal? Saldo_Neto { get; set; }

        public decimal? Saldo_Almacen { get; set; }
    }
}
