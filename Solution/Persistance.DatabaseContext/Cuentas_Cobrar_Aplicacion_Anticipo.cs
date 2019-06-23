namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cuentas_Cobrar_Aplicacion_Anticipo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int? Numero_Factura { get; set; }

        public int? Numero_Anticipo { get; set; }

        public int? Numero_NC { get; set; }

        public DateTime? Fecha { get; set; }

        public int? Estatus { get; set; }

        public int? Contabilizador { get; set; }

        public int? Numero_CC { get; set; }
    }
}
