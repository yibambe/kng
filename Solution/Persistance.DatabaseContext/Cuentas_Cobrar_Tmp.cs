namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cuentas_Cobrar_Tmp
    {
        public int? Numero_Orden { get; set; }

        public int? Numero_Empresa { get; set; }

        public int? Numero { get; set; }

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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Familia_Moneda { get; set; }

        public decimal? Saldo_Inicial { get; set; }

        [StringLength(50)]
        public string Numero_Factura_Abono { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public decimal? Monto_Nal { get; set; }

        public decimal? Cargo_Nal { get; set; }

        public decimal? Abono_Nal { get; set; }

        public decimal? Abono_Origen { get; set; }

        public int? Moneda_Origen { get; set; }

        public int? Numero_Vendedor { get; set; }

        public decimal? Tipo_Cambio_Integra { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(2000)]
        public string Observaciones { get; set; }

        public byte? Credito { get; set; }
    }
}
