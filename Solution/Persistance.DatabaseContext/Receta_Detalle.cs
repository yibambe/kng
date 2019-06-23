namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Receta_Detalle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Receta_Detalle()
        {
            Almacen_Sol_Prod_Detalle = new HashSet<Almacen_Sol_Prod_Detalle>();
            Orden_Produccion_Detalle = new HashSet<Orden_Produccion_Detalle>();
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

        public int Clasificacion_Producto { get; set; }

        public int Clasificacion_Concepto { get; set; }

        public int Familia_Producto { get; set; }

        public decimal Cantidad { get; set; }

        public int Unidad_Medida { get; set; }

        public int Familia_UMedida { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Almacen_Sol_Prod_Detalle> Almacen_Sol_Prod_Detalle { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orden_Produccion_Detalle> Orden_Produccion_Detalle { get; set; }

        public virtual Receta Receta { get; set; }
    }
}
