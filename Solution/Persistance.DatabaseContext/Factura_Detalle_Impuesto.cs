namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Factura_Detalle_Impuesto
    {
        public int? Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Factura { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cotiza { get; set; }

        public int? Numero_Partida { get; set; }

        public int? Num_Impuesto { get; set; }

        [StringLength(5)]
        public string Operacion { get; set; }

        public decimal? Valor { get; set; }

        public decimal? Importe { get; set; }
    }
}
