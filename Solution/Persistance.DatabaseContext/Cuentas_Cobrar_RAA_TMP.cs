namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cuentas_Cobrar_RAA_TMP
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Usuario { get; set; }

        public int? Numero_Cliente { get; set; }

        public int? Moneda { get; set; }

        [StringLength(50)]
        public string Documento { get; set; }

        public DateTime? Fecha { get; set; }

        public decimal? Monto { get; set; }

        public byte? Familia { get; set; }
    }
}
