namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Metodo_Costeo_Rangos
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Almacen { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Secuencia { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Desde { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Hasta { get; set; }

        public int Tipo_Costeo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Costeo { get; set; }

        public int Usuario { get; set; }

        public virtual Usuario Usuario1 { get; set; }
    }
}
