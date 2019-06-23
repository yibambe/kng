namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacturacionDefinicionTimbrado")]
    public partial class FacturacionDefinicionTimbrado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDFACDEFTIM { get; set; }

        [Required]
        [StringLength(75)]
        public string DESCRIPCION { get; set; }
    }
}
