namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transporte_Rutas_Permiso
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Transporte_Rutas { get; set; }

        public DateTime Fecha { get; set; }

        public int Usuario { get; set; }

        public int? Usuario_Permiso { get; set; }

        public DateTime? Fecha_Permiso { get; set; }

        public virtual Transporte_Rutas Transporte_Rutas { get; set; }
    }
}
