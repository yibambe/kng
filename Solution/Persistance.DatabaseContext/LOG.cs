namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOG")]
    public partial class LOG
    {
        [Key]
        public int IDLOG { get; set; }

        [StringLength(50)]
        public string IP { get; set; }

        [StringLength(250)]
        public string LOCATION { get; set; }

        [StringLength(50)]
        public string OS_BROWSER { get; set; }

        [StringLength(50)]
        public string FUNCTION_METHOD { get; set; }

        [StringLength(50)]
        public string MODULE { get; set; }

        [Required]
        [StringLength(15)]
        public string OWNER { get; set; }

        public DateTime DATECREATION { get; set; }

        public DateTime DATEUPDATE { get; set; }

        [StringLength(250)]
        public string DETAIL { get; set; }
    }
}
