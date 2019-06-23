namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Banco_Concepto_Conciliacion
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Banco { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Concepto_Interno { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(200)]
        public string Concepto_Interno { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(200)]
        public string Concepto_Banco { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string Clave_Banco { get; set; }

        public int? Familia_Clas_Concepto_Interno { get; set; }
    }
}
