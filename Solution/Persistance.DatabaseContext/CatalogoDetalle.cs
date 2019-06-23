namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CatalogoDetalle")]
    public partial class CatalogoDetalle
    {
        public int CATALOGODETALLEID { get; set; }

        public int CATALOGOID { get; set; }

        public string CATALOGODETALLECLAVE { get; set; }

        [Required]
        public string CATALOGODETALLEDESCRIPCION { get; set; }

        public string DESCRIPCION2 { get; set; }

        public bool CATALOGODETALLEACTIVO { get; set; }

        [Required]
        public string OWNER { get; set; }

        public DateTime DATECREATION { get; set; }

        public DateTime DATEUPDATE { get; set; }

        public int? EMPRESA { get; set; }

        public string D1 { get; set; }

        public string D2 { get; set; }

        public int? CONSECUTIVO { get; set; }

        public virtual Catalogo Catalogo { get; set; }
    }
}
