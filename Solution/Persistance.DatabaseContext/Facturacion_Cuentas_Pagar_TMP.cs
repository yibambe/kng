namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Facturacion_Cuentas_Pagar_TMP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int? Numero_Proveedor { get; set; }

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

        public int? Usuario { get; set; }

        public int? Moneda { get; set; }

        public int? Num_Banco { get; set; }

        public int? Num_Cuenta { get; set; }

        public int? Num_Caja { get; set; }

        public int? Tipo_Persona { get; set; }

        public int? Clas_IVA { get; set; }

        public int? Clas_Gasto { get; set; }

        public int? Familia { get; set; }

        public int? Familia_Moneda { get; set; }

        public int? Familia_IVA { get; set; }

        public int? Numero_Movimiento_Banco { get; set; }

        public int? Numero_Movimiento_Caja { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public int? Clas_Centro_Costo { get; set; }

        public int? Clas_CC { get; set; }

        public decimal? TC_Mes { get; set; }

        public short? Estatus { get; set; }

        public DateTime? Fecha_Eliminacion { get; set; }

        public int? Clas_Tipo_Gasto { get; set; }

        public int? Prorrateo { get; set; }

        public byte? Anticipo { get; set; }

        public int? Estatus_TMP { get; set; }
    }
}
