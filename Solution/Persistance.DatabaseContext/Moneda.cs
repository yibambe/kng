namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Moneda")]
    public partial class Moneda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [StringLength(10)]
        public string Clave { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        [StringLength(10)]
        public string Clave1 { get; set; }
    }
}
