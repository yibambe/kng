namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cliente_Referencia
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cliente { get; set; }

        [StringLength(50)]
        public string Numero_Proveedor { get; set; }

        [StringLength(50)]
        public string Referencia1 { get; set; }

        [StringLength(50)]
        public string Referencia2 { get; set; }

        [StringLength(50)]
        public string Referencia3 { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
