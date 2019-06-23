namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Caja_Dotacion_Comprobacion
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Dotacion { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Comprobante { get; set; }

        public int Numero_Egreso { get; set; }

        public virtual Caja_Comprobacion Caja_Comprobacion { get; set; }

        public virtual Caja_Dotacion Caja_Dotacion { get; set; }

        public virtual Caja_Egreso Caja_Egreso { get; set; }
    }
}
