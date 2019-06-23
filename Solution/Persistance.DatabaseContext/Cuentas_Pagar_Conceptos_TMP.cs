namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cuentas_Pagar_Conceptos_TMP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string Tipo { get; set; }

        public byte? Auxiliar { get; set; }

        public byte? Cheque { get; set; }

        public byte? Anticipo { get; set; }
    }
}
