namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Facturas_Periodicas_Encabezado
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cliente { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Moneda { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime Fecha_Emision { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime Fecha_Revision { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime Fecha_Pago { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Persona_Factura { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Factura { get; set; }

        public decimal? SubTotal { get; set; }

        public decimal? Descuento { get; set; }

        public decimal? Iva { get; set; }

        public decimal? Total { get; set; }

        public DateTime? Fecha_Pagada { get; set; }

        [StringLength(200)]
        public string Importe_Letra { get; set; }

        public int? Impresion { get; set; }

        public int? Estatus { get; set; }

        public int? Numero_Cotizacion { get; set; }

        public int? Tipo_Docto { get; set; }

        public short? Familia_Moneda { get; set; }

        public short? Fasmilia_Estatus { get; set; }

        public short? Familia_Tipo_Docto { get; set; }

        public short? Tipo { get; set; }

        public DateTime? Fecha_Cancelacion { get; set; }

        public int? Usuario { get; set; }

        [StringLength(250)]
        public string Causa { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tipo_Factura_Relacion { get; set; }
    }
}
