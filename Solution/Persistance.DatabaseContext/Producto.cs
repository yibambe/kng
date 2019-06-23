namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producto")]
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            Producto_Cliente = new HashSet<Producto_Cliente>();
            Productos_Conceptos = new HashSet<Productos_Conceptos>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clasificacion { get; set; }

        public int Tipo_producto { get; set; }

        public int? Clasificacion_articulo { get; set; }

        [StringLength(50)]
        public string Caracteristicas { get; set; }

        public int? Forma_entrega { get; set; }

        public int? Moneda { get; set; }

        public double? Comision { get; set; }

        public int? Estatus { get; set; }

        public int Familia_Prod_Tipo_Estatus { get; set; }

        public int Familia_Art { get; set; }

        public int Familia_Moneda { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }

        public virtual Clasificacion Clasificacion3 { get; set; }

        public virtual Clasificacion Clasificacion4 { get; set; }

        public virtual Clasificacion Clasificacion5 { get; set; }

        public virtual Empresa Empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto_Cliente> Producto_Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos_Conceptos> Productos_Conceptos { get; set; }
    }
}
