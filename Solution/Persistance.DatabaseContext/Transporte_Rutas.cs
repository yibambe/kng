namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transporte_Rutas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transporte_Rutas()
        {
            Transporte_Rutas_Detalle = new HashSet<Transporte_Rutas_Detalle>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public byte Estatus { get; set; }

        public DateTime Fecha_Programada { get; set; }

        public DateTime Hora_Carga_Inicial { get; set; }

        public int Numero_Unidad { get; set; }

        [Required]
        [StringLength(1024)]
        public string Observaciones { get; set; }

        public DateTime? Usuario_Cancelacion { get; set; }

        public DateTime? Fecha_Cancelacion { get; set; }

        public decimal? Hora_Extra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transporte_Rutas_Detalle> Transporte_Rutas_Detalle { get; set; }

        public virtual Transporte_Rutas_Permiso Transporte_Rutas_Permiso { get; set; }

        public virtual Transporte_Vehiculo Transporte_Vehiculo { get; set; }
    }
}
