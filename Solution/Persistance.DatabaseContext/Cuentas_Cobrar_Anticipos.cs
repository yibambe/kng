namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cuentas_Cobrar_Anticipos
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int? Numero_Cliente { get; set; }

        public int? Numero_Concepto { get; set; }

        [StringLength(50)]
        public string Documento { get; set; }

        [StringLength(50)]
        public string Numero_Referencia { get; set; }

        public DateTime? Fecha_Aplicacion { get; set; }

        public DateTime? Fecha_Vencimiento { get; set; }

        public decimal? Monto { get; set; }

        public decimal? Cargo { get; set; }

        public decimal? Abono { get; set; }

        public decimal? Saldo { get; set; }

        [StringLength(50)]
        public string Numero_Factura { get; set; }

        public int? Usuario { get; set; }

        public int? Moneda { get; set; }

        public int? Num_Banco { get; set; }

        public int? Num_Cuenta { get; set; }

        public int? Num_Caja { get; set; }

        public int? Clas_Tipo_Documento { get; set; }

        public int? Clas_IVA { get; set; }

        public short? Familia_Tipo_Documento { get; set; }

        public short? Tipo_Documento_CC { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Familia_Moneda { get; set; }

        public int? Numero_Movimiento_Banco { get; set; }

        public int? Numero_Movimiento_Caja { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public decimal? TC_Mes { get; set; }

        public short? Estatus { get; set; }

        public DateTime? Fecha_Eliminacion { get; set; }

        public byte? Aplicado { get; set; }

        public int? Num_Serie { get; set; }

        public int? Clas_Forma_Pago { get; set; }

        public decimal? Subtotal { get; set; }

        public decimal? Iva { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        public string UsoCFDI { get; set; }

        [StringLength(50)]
        public string Metodo_Pago { get; set; }

        [StringLength(50)]
        public string Folio_Fiscal { get; set; }

        public byte? Contabilizada { get; set; }

        public byte? Flag { get; set; }

        public int? Estatus_SAT { get; set; }

        [StringLength(10)]
        public string nombre_programa { get; set; }

        public int? numero_llave { get; set; }
    }
}
