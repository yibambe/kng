namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transporte_Vehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transporte_Vehiculo()
        {
            Transporte_Rutas = new HashSet<Transporte_Rutas>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Clas_Unidad { get; set; }

        public int Persona_Operador { get; set; }

        public decimal Capacidad_Max { get; set; }

        [Required]
        [StringLength(20)]
        public string Placas { get; set; }

        public int Familia_Unidad { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual RH_Persona RH_Persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transporte_Rutas> Transporte_Rutas { get; set; }
    }
}
