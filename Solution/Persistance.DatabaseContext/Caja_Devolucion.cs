namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Caja_Devolucion
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Numero_Adeudo { get; set; }

        public int Numero_Banco { get; set; }

        public int Cont_Clas_Cuenta { get; set; }

        public int Clas_Concepto { get; set; }

        public decimal Importe { get; set; }

        public short Poliza { get; set; }

        public int? Numero_Reg_Cheques { get; set; }

        [StringLength(100)]
        public string Folio { get; set; }

        public int Familia { get; set; }
    }
}