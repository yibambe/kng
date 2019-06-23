namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orden_Compras_Factura
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int? Persona_Proveedor { get; set; }

        public DateTime? Fecha { get; set; }

        public int? Numero_OC { get; set; }

        public byte? Tipo1 { get; set; }

        [StringLength(25)]
        public string Numero_Factura { get; set; }

        public int? Cant_Forma_Pago { get; set; }

        public int? Forma_Pago { get; set; }

        public int? Moneda { get; set; }

        public decimal? Descuento { get; set; }

        public decimal? Comision { get; set; }

        public int? IVA { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        [StringLength(500)]
        public string Observaciones { get; set; }

        public DateTime? Fecha_Pago { get; set; }

        public DateTime? Fecha_Vencimiento { get; set; }

        public int? Concepto { get; set; }

        public byte? Contabilizada { get; set; }

        public int? OC_Almacen { get; set; }

        public int? Numero_Entrada { get; set; }

        public short? Familia_Moneda { get; set; }

        public short? Familia_IVA { get; set; }

        public short? Familia { get; set; }

        public DateTime? Fecha_Revision { get; set; }
    }
}
