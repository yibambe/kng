namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bancos_Conciliacion
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Numero_Banco { get; set; }

        public int Clas_Cuenta { get; set; }

        public DateTime? Fecha_Inicio { get; set; }

        public DateTime? Fecha_Fin { get; set; }

        public int Usuario { get; set; }

        public int Familia { get; set; }
    }
}
