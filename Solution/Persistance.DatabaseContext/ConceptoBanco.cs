namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConceptoBanco")]
    public partial class ConceptoBanco
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Banco { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string ConceptoInterno { get; set; }

        [Column("ConceptoBanco")]
        [StringLength(30)]
        public string ConceptoBanco1 { get; set; }
    }
}
