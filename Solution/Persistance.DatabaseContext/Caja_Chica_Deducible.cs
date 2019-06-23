namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Caja_Chica_Deducible
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Numero { get; set; }

        [StringLength(1000)]
        public string Descripcion { get; set; }

        public byte? Deducible { get; set; }

        public int? Clas_Concepto { get; set; }

        public int? Familia_Concepto { get; set; }

        public byte Estatus { get; set; }

        public DateTime? Fecha { get; set; }

        public int? Numero_Poliza { get; set; }
    }
}
