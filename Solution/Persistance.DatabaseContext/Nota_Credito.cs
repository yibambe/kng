namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Nota_Credito
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Numero_Cliente { get; set; }

        public DateTime Fecha { get; set; }

        public byte Tipo_Concepto_Importe { get; set; }

        public int Clas_Iva { get; set; }

        public int Tipo_Docto_Nota { get; set; }

        public int Tipo_Docto_Nota_Relacion { get; set; }

        [Required]
        [StringLength(100)]
        public string Numero_Nota { get; set; }

        public int Clas_Moneda { get; set; }

        public int Clas_Concepto { get; set; }

        public string Comentario { get; set; }

        public decimal Subtotal { get; set; }

        public decimal Descuento { get; set; }

        public decimal Iva { get; set; }

        public decimal Total { get; set; }

        [Required]
        [StringLength(1000)]
        public string Importe_Letra { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public int Numero_Persona_Aplicada { get; set; }

        public int Clas_Estatus { get; set; }

        public int? Tipo_Docto { get; set; }

        public int? Tipo_Docto_Relacion { get; set; }

        public int? Numero_Reg_Docto { get; set; }

        [StringLength(100)]
        public string Numero_Docto { get; set; }

        public short Tipo_Transaccion { get; set; }

        [StringLength(100)]
        public string Numero_Factura_Relacion { get; set; }

        public int? Numero_CXC { get; set; }

        public DateTime? Fecha_Cancelacion { get; set; }

        [StringLength(500)]
        public string Causa { get; set; }

        public int Contabilizada { get; set; }

        public int? Usuario { get; set; }

        public int Familia_Docto { get; set; }

        public int Familia_Moneda { get; set; }

        public int Familia_Concepto { get; set; }

        public DateTime? Hora_Nota { get; set; }

        public int? Clas_Sucursal { get; set; }

        public int? Familia_Sucursal { get; set; }

        public int? Usuario_Captura { get; set; }

        public byte? Relacion_Factura { get; set; }

        [StringLength(50)]
        public string Folio_Fiscal { get; set; }

        public int? UsoCFDI { get; set; }

        public int? ESTATUS_SAT { get; set; }

        [StringLength(10)]
        public string Nombre_Programa { get; set; }

        public int? Numero_Llave { get; set; }

        public byte? Anticipo { get; set; }

        public int? cfdi_metodopago { get; set; }
    }
}
