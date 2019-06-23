namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Almacen_Requerimiento_Stock
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public DateTime Fecha { get; set; }

        public int Clas_Almacen { get; set; }

        public int Usuario { get; set; }

        public int? Requerido { get; set; }

        public int Tipo { get; set; }

        public int Familia { get; set; }

        public int? Numero_Registro { get; set; }

        public int? Tipo_Solicitud { get; set; }
    }
}
