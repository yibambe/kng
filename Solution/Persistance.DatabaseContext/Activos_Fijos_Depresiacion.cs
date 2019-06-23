namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Activos_Fijos_Depresiacion
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Numero_Activo_Fijo_Alta { get; set; }

        public int Numero_Detalle { get; set; }

        public int Numero_Depresiacion { get; set; }

        public DateTime Fecha { get; set; }

        public decimal Importe { get; set; }

        public byte Contabilizado { get; set; }

        public int Clas_Concepto { get; set; }

        public int Familia { get; set; }
    }
}
