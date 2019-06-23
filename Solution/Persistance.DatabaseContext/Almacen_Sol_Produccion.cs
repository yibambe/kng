namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Almacen_Sol_Produccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Almacen_Sol_Produccion()
        {
            Almacen_Sol_Prod_Detalle = new HashSet<Almacen_Sol_Prod_Detalle>();
            Almacen_Sol_Prod_Empaques = new HashSet<Almacen_Sol_Prod_Empaques>();
            Sol_Prod_Detalle_Transformada = new HashSet<Sol_Prod_Detalle_Transformada>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Solicitud { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha { get; set; }

        public int Estatus { get; set; }

        public int Familia_Estatus { get; set; }

        public int Usuario { get; set; }

        public int Numero_Almacen { get; set; }

        public int Familia_Almacen { get; set; }

        public int Numero_Orden { get; set; }

        public int chk_Solicitud { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Almacen_Sol_Prod_Detalle> Almacen_Sol_Prod_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Almacen_Sol_Prod_Empaques> Almacen_Sol_Prod_Empaques { get; set; }

        public virtual Orden_Produccion Orden_Produccion { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sol_Prod_Detalle_Transformada> Sol_Prod_Detalle_Transformada { get; set; }
    }
}
