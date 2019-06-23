namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Almacen_Inventario
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Almacen { get; set; }

        public DateTime Fecha { get; set; }

        public byte? Suspencion { get; set; }

        public DateTime? Fecha_Suspencion { get; set; }

        public DateTime? Hora_Suspencion { get; set; }

        public byte? Reanudacion { get; set; }

        public DateTime? Fecha_Reanudacion { get; set; }

        public DateTime? Hora_Reanudacion { get; set; }

        public int Familia_Almacen { get; set; }
    }
}
