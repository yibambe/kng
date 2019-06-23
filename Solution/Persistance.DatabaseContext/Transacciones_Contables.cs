namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transacciones_Contables
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Transaccion { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Programa { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cuenta { get; set; }

        public bool Acumulativa_Detalle { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cargo_Abono { get; set; }

        public double? Porcentaje { get; set; }

        [StringLength(250)]
        public string Concepto { get; set; }

        public int? Auxiliar { get; set; }

        public int Tipo_Poliza { get; set; }

        public int? Familia { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
