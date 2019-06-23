namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bancos_Mon_Ext_Revaluado_Rpt
    {
        public int? Numero_Empresa { get; set; }

        public DateTime? Fecha { get; set; }

        public int? Clas_Moneda { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public int? Num_Banco { get; set; }

        public int? Clas_Cuenta { get; set; }

        public decimal? Saldo { get; set; }

        public decimal? Saldo_Revaluado { get; set; }

        public int? Usuario { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Familia_Moneda { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Familia_Cuenta { get; set; }
    }
}
