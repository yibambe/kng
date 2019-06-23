namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalogo")]
    public partial class Catalogo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Catalogo()
        {
            CatalogoDetalles = new HashSet<CatalogoDetalle>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CATALOGOID { get; set; }

        [Required]
        [StringLength(200)]
        public string CATALOGODESCRIPCION { get; set; }

        public bool CATALOGOACTIVO { get; set; }

        [Required]
        [StringLength(15)]
        public string OWNER { get; set; }

        public DateTime DATECREATION { get; set; }

        public DateTime DATEUPDATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CatalogoDetalle> CatalogoDetalles { get; set; }
    }
}
