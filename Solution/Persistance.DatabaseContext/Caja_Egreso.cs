namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Caja_Egreso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Caja_Egreso()
        {
            Caja_Arqueo_Detalle = new HashSet<Caja_Arqueo_Detalle>();
            Caja_Comprobacion = new HashSet<Caja_Comprobacion>();
            Caja_Dotacion_Comprobacion = new HashSet<Caja_Dotacion_Comprobacion>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Numero_Caja { get; set; }

        [StringLength(500)]
        public string Motivo { get; set; }

        public decimal Importe { get; set; }

        [Required]
        [StringLength(100)]
        public string Num_Vale { get; set; }

        public int Persona_Asignado { get; set; }

        public int Clas_Estatus { get; set; }

        public int Usuario { get; set; }

        public DateTime Fecha_Ingreso { get; set; }

        [StringLength(500)]
        public string Observacion { get; set; }

        public int? Familia { get; set; }

        public int Cancelado { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public virtual Caja Caja { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Arqueo_Detalle> Caja_Arqueo_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Comprobacion> Caja_Comprobacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Dotacion_Comprobacion> Caja_Dotacion_Comprobacion { get; set; }
    }
}
