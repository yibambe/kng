namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Administracion_Recursos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Administracion_Recursos()
        {
            Administracion_Recursos_Detalle = new HashSet<Administracion_Recursos_Detalle>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Admon { get; set; }

        [Required]
        [StringLength(30)]
        public string Clave { get; set; }

        [Required]
        [StringLength(150)]
        public string Descripcion { get; set; }

        public int Numero_TRecurso { get; set; }

        public int Familia_TRecurso { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Administracion_Recursos_Detalle> Administracion_Recursos_Detalle { get; set; }
    }
}
