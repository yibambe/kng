namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Deudor_Gastos
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_persona { get; set; }

        public int? Clasificacion_Deudor { get; set; }

        public DateTime? Fecha_alta { get; set; }

        public int? Estatus { get; set; }

        [Column(TypeName = "text")]
        public string Observaciones { get; set; }

        public int? Cont_Clas_Deudor { get; set; }

        public short Familia { get; set; }

        public short? Forma_Pago { get; set; }

        public int? Clas_Forma_Pago { get; set; }

        public int? Clas_Moneda { get; set; }

        public int? Familia_Moneda { get; set; }
    }
}
