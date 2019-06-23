namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Condiciones_Facturacion_Pago
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int Numero_Cliente_Persona { get; set; }

        public int? Tipo_Revision_Pago { get; set; }

        [StringLength(20)]
        public string Dia_Pago { get; set; }

        public DateTime? Hora_Ini_Pago { get; set; }

        public DateTime? Hora_Fin_Pago { get; set; }

        public int? Dias_Para_Pago { get; set; }

        public int? Dia { get; set; }

        public int? Dias_Vencimiento { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
