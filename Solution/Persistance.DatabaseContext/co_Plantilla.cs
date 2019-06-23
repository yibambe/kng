namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class co_Plantilla
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public co_Plantilla()
        {
            co_Reportes_Contables = new HashSet<co_Reportes_Contables>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Plantilla { get; set; }

        [Required]
        [StringLength(150)]
        public string Descripcion { get; set; }

        public int Orden { get; set; }

        public int? Numero_Columnas { get; set; }

        [StringLength(50)]
        public string Nombre_Reporte { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<co_Reportes_Contables> co_Reportes_Contables { get; set; }
    }
}
