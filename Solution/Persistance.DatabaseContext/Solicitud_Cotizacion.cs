namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Solicitud_Cotizacion
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
        public byte Tipo1 { get; set; }

        public int? Clas_Estatus { get; set; }

        public DateTime? Fecha { get; set; }

        public int? Numero_RC { get; set; }

        public DateTime? Fecha_Entrega { get; set; }

        public int? Persona { get; set; }

        public short? Familia { get; set; }
    }
}
