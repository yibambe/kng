namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Nota_Credito_Detalle
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Registro_Nota { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte Tipo_Importe_Concepto { get; set; }

        public decimal? Importe { get; set; }

        public int? Numero_Cotiza { get; set; }

        public int? Numero_Cotiza_detalle { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Familia { get; set; }

        public decimal? Cantidad { get; set; }

        public int? Secuencia { get; set; }
    }
}
