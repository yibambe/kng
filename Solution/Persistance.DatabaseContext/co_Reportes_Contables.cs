namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class co_Reportes_Contables
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public co_Reportes_Contables()
        {
            co_Reportes_Contables_Detalle = new HashSet<co_Reportes_Contables_Detalle>();
            co_Reportes_Contables_Importes = new HashSet<co_Reportes_Contables_Importes>();
            co_Reportes_Contables_Registros = new HashSet<co_Reportes_Contables_Registros>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Reporte { get; set; }

        [Required]
        [StringLength(150)]
        public string Descripcion { get; set; }

        public int Numero_Plantilla { get; set; }

        public int Tipo_Reporte { get; set; }

        public byte? Saldo_Mes { get; set; }

        public byte? Horizontal { get; set; }

        public int Numero_Usuario { get; set; }

        public virtual co_Plantilla co_Plantilla { get; set; }

        public virtual Persona Persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<co_Reportes_Contables_Detalle> co_Reportes_Contables_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<co_Reportes_Contables_Importes> co_Reportes_Contables_Importes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<co_Reportes_Contables_Registros> co_Reportes_Contables_Registros { get; set; }
    }
}
