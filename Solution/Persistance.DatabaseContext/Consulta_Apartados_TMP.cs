namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Consulta_Apartados_TMP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Usuario { get; set; }

        public int? Clas_Sucursal { get; set; }

        [StringLength(80)]
        public string Des_Sucursal { get; set; }

        public int? Clas_Almacen { get; set; }

        [StringLength(80)]
        public string Des_Almacen { get; set; }

        public int? Num_Cotiza { get; set; }

        [StringLength(80)]
        public string Cotiza_Estatus { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Cotiza { get; set; }

        public int? Num_Cliente { get; set; }

        [StringLength(300)]
        public string Nombre_Cliente { get; set; }

        public int? Clas_TProducto { get; set; }

        [StringLength(80)]
        public string Cve_TProducto { get; set; }

        [StringLength(80)]
        public string Des_TProducto { get; set; }

        public int? Clas_Producto { get; set; }

        [StringLength(80)]
        public string Cve_Producto { get; set; }

        [StringLength(80)]
        public string Des_Producto { get; set; }

        public int? Clas_TConcepto { get; set; }

        [StringLength(80)]
        public string Cve_TConcepto { get; set; }

        [StringLength(80)]
        public string Des_TConcepto { get; set; }

        public int? Clas_Concepto { get; set; }

        [StringLength(80)]
        public string Cve_Concepto { get; set; }

        [StringLength(80)]
        public string Des_Concepto { get; set; }

        public decimal? Cantidad_Solicitada { get; set; }

        public decimal? Cantidad_Entregada { get; set; }

        public decimal? Cantidad_Restante { get; set; }

        public int? Numero_Factura { get; set; }

        [StringLength(80)]
        public string Folio_Factura { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Emision { get; set; }

        [StringLength(80)]
        public string Factura_Estatus { get; set; }

        [StringLength(80)]
        public string Tipo_Documento { get; set; }

        [StringLength(100)]
        public string Serie { get; set; }
    }
}
