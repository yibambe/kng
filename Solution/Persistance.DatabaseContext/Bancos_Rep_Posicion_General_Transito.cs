namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bancos_Rep_Posicion_General_Transito
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Usuario { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [StringLength(100)]
        public string Campo { get; set; }

        [StringLength(100)]
        public string Campo1 { get; set; }

        [StringLength(100)]
        public string Campo2 { get; set; }

        [StringLength(100)]
        public string Campo3 { get; set; }

        [StringLength(100)]
        public string Campo4 { get; set; }

        [StringLength(100)]
        public string Campo5 { get; set; }
    }
}
