namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Plan_Produccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plan_Produccion()
        {
            Plan_Prod_Fechas = new HashSet<Plan_Prod_Fechas>();
            Plan_Produccion_Detalle = new HashSet<Plan_Produccion_Detalle>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Plan { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Inicio { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Fin { get; set; }

        public int? Opcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plan_Prod_Fechas> Plan_Prod_Fechas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plan_Produccion_Detalle> Plan_Produccion_Detalle { get; set; }
    }
}
