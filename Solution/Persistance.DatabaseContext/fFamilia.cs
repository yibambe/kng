namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fFamilia")]
    public partial class fFamilia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Folio { get; set; }
    }
}
