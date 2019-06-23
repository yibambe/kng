namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contabilidad_Cuenta_Mayor
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Des_Cuenta_Mayor { get; set; }

        public int? Clas_Cuenta_Mayor { get; set; }

        [StringLength(50)]
        public string Des_Clave_Mayor { get; set; }

        public short? Tipo_Cuenta { get; set; }
    }
}
