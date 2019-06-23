namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Banco_Movimiento_Transferencia
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public short Cargo_Abono { get; set; }

        public DateTime Fecha { get; set; }

        public int Num_Banco { get; set; }

        public int Num_Cuenta { get; set; }

        [StringLength(50)]
        public string Referencia { get; set; }

        [StringLength(50)]
        public string Recibo { get; set; }

        public decimal Importe { get; set; }

        public int Clas_Concepto { get; set; }

        public int Familia { get; set; }
    }
}
