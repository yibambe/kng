namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FE_Datos_CFDI_CxP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Usuario { get; set; }

        [StringLength(50)]
        public string Comprobante_Folio { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Comprobante_Fecha { get; set; }

        public decimal? Comprobante_Total { get; set; }

        [StringLength(500)]
        public string Comprobante_Moneda { get; set; }

        public decimal? Comprobante_TC { get; set; }

        [StringLength(50)]
        public string Emisor_RFC { get; set; }

        [StringLength(1000)]
        public string Emisor_Nombre { get; set; }

        [StringLength(1000)]
        public string Emisor_Calle { get; set; }

        [StringLength(1000)]
        public string Emisor_Exterior { get; set; }

        [StringLength(1000)]
        public string Emisor_Colonia { get; set; }

        [StringLength(1000)]
        public string Emisor_Localidad { get; set; }

        [StringLength(1000)]
        public string Emisor_Municipio { get; set; }

        [StringLength(1000)]
        public string Emisor_Estado { get; set; }

        [StringLength(500)]
        public string Emisor_Pais { get; set; }

        [StringLength(100)]
        public string Emisor_CP { get; set; }

        [StringLength(50)]
        public string Receptor_RFC { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(4000)]
        public string Folio_Fiscal { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(5000)]
        public string Carpeta_Importaciones { get; set; }

        public int? Numero_CxP_Encontrado { get; set; }

        public int? Numero_Proveedor { get; set; }

        public int? Relacion { get; set; }
    }
}
