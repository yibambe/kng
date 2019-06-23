namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Control_Procesos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Control_Procesos()
        {
            Actualizacion_Controles_Detalle = new HashSet<Actualizacion_Controles_Detalle>();
            Personas = new HashSet<Persona>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int Numero_Receta { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Numero_Proceso { get; set; }

        public int Familia_Proceso { get; set; }

        public int Secuencia { get; set; }

        [Required]
        [StringLength(8)]
        public string Tiempo { get; set; }

        public decimal Costo { get; set; }

        public int Tipo_Proceso { get; set; }

        public int Familia_TProceso { get; set; }

        public int? Dependiente { get; set; }

        public int? Numero_Persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Actualizacion_Controles_Detalle> Actualizacion_Controles_Detalle { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Receta Receta { get; set; }

        public virtual Persona Persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
