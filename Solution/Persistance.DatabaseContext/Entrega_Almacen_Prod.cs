namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Entrega_Almacen_Prod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Entrega_Almacen_Prod()
        {
            Entrega_Almacen_Prod_Detalle = new HashSet<Entrega_Almacen_Prod_Detalle>();
            Entrega_Almacen_Prod_Motivos = new HashSet<Entrega_Almacen_Prod_Motivos>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int Numero_Orden { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Entrega { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Fecha_Caducidad { get; set; }

        public virtual Orden_Produccion Orden_Produccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrega_Almacen_Prod_Detalle> Entrega_Almacen_Prod_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrega_Almacen_Prod_Motivos> Entrega_Almacen_Prod_Motivos { get; set; }
    }
}
