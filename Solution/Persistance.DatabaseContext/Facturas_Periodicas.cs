namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Facturas_Periodicas
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cotizacion { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cotizacion_Detalle { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Orden { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Producto { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tipo_Concepto { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Concepto { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal Cantidad { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal Precio { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal Descuento_Art { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal Importe { get; set; }

        public DateTime? Fecha { get; set; }

        public DateTime? Fecha_Revision { get; set; }

        public DateTime? Fecha_Pago { get; set; }

        public DateTime? Fecha_Factura { get; set; }

        public int? Persona_Factura { get; set; }

        [StringLength(10)]
        public string Numero_Factura_Periodica_Encabezado { get; set; }

        public short? Familia_Producto_Tipo_Producto_Concepto { get; set; }
    }
}
