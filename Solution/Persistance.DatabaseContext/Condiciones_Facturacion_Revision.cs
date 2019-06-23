namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Condiciones_Facturacion_Revision
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int? Numero_Empresa { get; set; }

        public int? Numero_Cliente_Persona { get; set; }

        public int? Tipo_Revision_Pago { get; set; }

        [StringLength(20)]
        public string Dia_Revision { get; set; }

        public DateTime? Hora_Ini_Revision { get; set; }

        public DateTime? Hora_Fin_Revision { get; set; }

        public int? Dia { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
