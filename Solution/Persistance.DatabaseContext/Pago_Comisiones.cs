namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pago_Comisiones
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Numero_Cotizacion { get; set; }

        public int Numero_Vendedor { get; set; }

        public decimal Comision { get; set; }

        public DateTime Fecha_Pago { get; set; }

        public int Cuentas_Pagar { get; set; }

        public byte? Autoriza { get; set; }

        public int? Numero_CXC { get; set; }
    }
}
