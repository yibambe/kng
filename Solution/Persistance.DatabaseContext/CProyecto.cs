namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CProyectos")]
    public partial class CProyecto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CProyecto()
        {
            CProyectos_Expediente = new HashSet<CProyectos_Expediente>();
            CProyectos_Tab = new HashSet<CProyectos_Tab>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [StringLength(120)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Nombre_Corto { get; set; }

        public int? Responsable { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public DateTime? Vigencia_De { get; set; }

        public DateTime? Vigencia_Hasta { get; set; }

        public byte? Estatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CProyectos_Expediente> CProyectos_Expediente { get; set; }

        public virtual RH_Persona RH_Persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CProyectos_Tab> CProyectos_Tab { get; set; }
    }
}
