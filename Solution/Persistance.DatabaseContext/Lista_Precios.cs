namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lista_Precios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lista_Precios()
        {
            Lista_Precios_Detalle = new HashSet<Lista_Precios_Detalle>();
            Lista_Precios_Detalle_TMP = new HashSet<Lista_Precios_Detalle_TMP>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }

        public int Clas_Tipo_Cliente { get; set; }

        public DateTime Fecha_Inicial { get; set; }

        public DateTime Fecha_Fin { get; set; }

        public int Familia_Tipo_Cliente { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lista_Precios_Detalle> Lista_Precios_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lista_Precios_Detalle_TMP> Lista_Precios_Detalle_TMP { get; set; }
    }
}
