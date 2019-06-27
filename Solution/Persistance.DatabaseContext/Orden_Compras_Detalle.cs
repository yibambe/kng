namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orden_Compras_Detalle
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_OC { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte Tipo1 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Numero_SC { get; set; }

        public int Tipo_Compra { get; set; }

        public int Compra { get; set; }

        public int Tipo_Concepto { get; set; }

        public int Concepto { get; set; }

        public decimal? Precio { get; set; }

        public decimal? Cantidad { get; set; }

        public int? Unidad_Medida { get; set; }

        public decimal? Cantidad_Facturada { get; set; }

        public short Familia { get; set; }

        public decimal? Descuento { get; set; }
    }
}