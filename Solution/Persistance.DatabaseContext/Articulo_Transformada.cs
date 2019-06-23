namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Articulo_Transformada
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Articulo_Transformada()
        {
            Articulo_Transformada_Detalle = new HashSet<Articulo_Transformada_Detalle>();
            MTransformada_MPrima = new HashSet<MTransformada_MPrima>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Numero_ATransformada { get; set; }

        public int Familia_ATransformada { get; set; }

        public int Numero_UMedida { get; set; }

        public int Familia_UMedida { get; set; }

        [StringLength(250)]
        public string Observaciones { get; set; }

        public int Numero_TProducto { get; set; }

        public int Numero_Producto { get; set; }

        public int Numero_TConcepto { get; set; }

        public decimal? Costo { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Articulo_Transformada_Detalle> Articulo_Transformada_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MTransformada_MPrima> MTransformada_MPrima { get; set; }
    }
}
