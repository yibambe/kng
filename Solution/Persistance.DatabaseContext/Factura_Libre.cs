namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Factura_Libre
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Cliente { get; set; }

        public DateTime Fecha_Emision { get; set; }

        public DateTime Fecha_Vencimiento { get; set; }

        public int Tipo_Docto { get; set; }

        public int Serie { get; set; }

        public int Numero_Docto { get; set; }

        public int Estatus { get; set; }

        public int Contabilizado { get; set; }

        [StringLength(30)]
        public string Referencia { get; set; }

        public int Clas_Moneda { get; set; }

        public decimal Tipo_Cambio { get; set; }

        public int? Concepto_Factura { get; set; }

        public int? Numero_Cotizacion { get; set; }

        public int? Numero_Factura { get; set; }

        public int Usuario { get; set; }

        public int Familia_moneda { get; set; }

        public int Familia_Tipo_Docto { get; set; }

        public int Familia_Estatus { get; set; }

        [StringLength(30)]
        public string Referencia2 { get; set; }

        [StringLength(30)]
        public string Referencia3 { get; set; }

        public byte? Nota_Cargo { get; set; }
    }
}
