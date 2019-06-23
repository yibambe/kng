namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Catalogo_Bandas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Catalogo_Bandas()
        {
            Banda_Relacion_Cliente = new HashSet<Banda_Relacion_Cliente>();
            Catalogo_Bandas_Detalle = new HashSet<Catalogo_Bandas_Detalle>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        public int Clas_Zona { get; set; }

        public decimal Importe_Min { get; set; }

        public int Familia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Banda_Relacion_Cliente> Banda_Relacion_Cliente { get; set; }

        public virtual Catalogo_Bandas Catalogo_Bandas1 { get; set; }

        public virtual Catalogo_Bandas Catalogo_Bandas2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Catalogo_Bandas_Detalle> Catalogo_Bandas_Detalle { get; set; }
    }
}
