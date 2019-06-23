namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Entrada_Salida_Almacen
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int? Numero_Usuario { get; set; }

        public int? Numero_Doc_Origen { get; set; }

        public DateTime? Fecha { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Entrada_Salida { get; set; }
    }
}
