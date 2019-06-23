namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Proveedor_Contrato
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int? Numero_Proveedor { get; set; }

        [StringLength(50)]
        public string Numero_Contrato { get; set; }

        public DateTime? Inicio_Vigencia { get; set; }

        public DateTime? Fin_Vigencia { get; set; }

        public int? Periodicidad_pago { get; set; }

        public int? Clas_Periodo { get; set; }

        [StringLength(50)]
        public string Dia_Pago { get; set; }

        public int? Moneda { get; set; }

        public int? Tiempo_Credito { get; set; }

        public int? Periodo_Credito { get; set; }

        public decimal? Monto_Credito { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Familia { get; set; }

        public int? Clas_Periodo2 { get; set; }

        public int? Dias_Credito { get; set; }
    }
}
