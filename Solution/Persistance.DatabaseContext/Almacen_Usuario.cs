namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Almacen_Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Numero_Empresa { get; set; }

        public int? Numero_Almacen { get; set; }

        public int? Numero_Usuario { get; set; }

        public byte? Propio { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
