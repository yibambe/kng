namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FImpuesto")]
    public partial class FImpuesto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Folio { get; set; }
    }
}
