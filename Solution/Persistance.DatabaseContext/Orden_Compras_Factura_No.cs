namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orden_Compras_Factura_No
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_OC_Factura { get; set; }

        public int? Numero { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_OC { get; set; }

        public byte? Tipo1 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Articulo_OC { get; set; }

        public decimal? Precio { get; set; }

        public decimal? Cantidad { get; set; }

        public int? Unidad_Medida { get; set; }

        public DateTime? Fecha_Recepcion { get; set; }

        public int? Gasto { get; set; }

        public int? OC_Almacen { get; set; }

        public int? Numero_Entrada { get; set; }

        public short? Familia { get; set; }

        public short? Familia_CC { get; set; }
    }
}
