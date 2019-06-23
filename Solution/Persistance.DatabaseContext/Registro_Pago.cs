namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Registro_Pago
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
        public int Numero { get; set; }

        public DateTime Fecha_Emision { get; set; }

        public DateTime Fecha_Revision { get; set; }

        public DateTime Fecha_Pago { get; set; }

        public int Moneda { get; set; }

        public decimal Descuento { get; set; }

        public decimal SubTotal { get; set; }

        public decimal IVA { get; set; }

        public decimal Total { get; set; }

        [Required]
        [StringLength(200)]
        public string Importe_Letra { get; set; }

        public int Total_Registro { get; set; }

        public int Numero_Cliente { get; set; }

        public int Persona_Recibo { get; set; }

        public int Estatus { get; set; }

        public short Comision_Calculada { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Orden { get; set; }

        public int? Tipo_Documento { get; set; }

        public int? Numero_Recibo_Factura { get; set; }

        public short Familia_Clas_Moneda { get; set; }

        public short? Familia_Clas_Estatus { get; set; }

        [StringLength(10)]
        public string Familia_Tipo_Documento { get; set; }

        public int? Numero_Concecutivo { get; set; }

        public short? Tipo { get; set; }

        public DateTime? Fecha_Cancelacion { get; set; }

        public int? Usuario { get; set; }

        [StringLength(250)]
        public string Causa { get; set; }

        public int Tipo_Factura_Relacion { get; set; }

        public virtual Cotizacion Cotizacion { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
