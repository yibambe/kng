namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Folio")]
    public partial class Folio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Folio()
        {
            Folio_Facultad = new HashSet<Folio_Facultad>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int Clas_Tipo_Docto { get; set; }

        public int? Clas_Moneda { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }

        [Column("Folio")]
        public int Folio1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Familia_Tipo_Docto { get; set; }

        public int Familia_Moneda { get; set; }

        public int? Facturadoras { get; set; }

        public int? Validadoras { get; set; }

        public byte? Docto_Internet { get; set; }

        [StringLength(10)]
        public string Prefijo { get; set; }

        public byte? CRP { get; set; }

        public virtual Empresa Empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Folio_Facultad> Folio_Facultad { get; set; }
    }
}
