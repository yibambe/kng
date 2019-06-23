namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CamposCheque")]
    public partial class CamposCheque
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Campo { get; set; }

        [Key]
        [Column(Order = 1)]
        public int c { get; set; }
    }
}
