namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vcp_Pagos_Multiples
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
        public int Numero_Pago { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime Fecha_Pago { get; set; }

        public int? Numero_Banco { get; set; }

        [StringLength(150)]
        public string Nombre_Banco { get; set; }

        public int? Clas_Cuenta { get; set; }

        [StringLength(150)]
        public string Numero_Cuenta { get; set; }

        [StringLength(150)]
        public string Folio { get; set; }

        [StringLength(150)]
        public string Documentos { get; set; }

        public decimal? Efectivo { get; set; }

        public int? Numero_Proveedor { get; set; }

        [StringLength(150)]
        public string Nombre_Cliente { get; set; }

        public int? Numero_Concepto { get; set; }

        [StringLength(150)]
        public string Des_Concepto { get; set; }

        [StringLength(150)]
        public string Documento { get; set; }

        public decimal? Importe_Factura { get; set; }

        [StringLength(150)]
        public string Comentario { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime Fecha_Aplicacion { get; set; }

        public decimal? Importe_Pago { get; set; }

        public decimal? Tipo_Cambio_Pago { get; set; }

        public int? Moneda_Pago { get; set; }

        [StringLength(50)]
        public string Nombre_Moneda_Pago { get; set; }

        public int? Anticipo { get; set; }

        [StringLength(150)]
        public string Documento_Anticipo { get; set; }
    }
}
