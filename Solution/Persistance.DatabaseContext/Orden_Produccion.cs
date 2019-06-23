namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orden_Produccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orden_Produccion()
        {
            Almacen_Sol_Produccion = new HashSet<Almacen_Sol_Produccion>();
            Avance_Orden_Produccion = new HashSet<Avance_Orden_Produccion>();
            Entrega_Almacen_Prod = new HashSet<Entrega_Almacen_Prod>();
            Liberacion_Pedidos_Prod = new HashSet<Liberacion_Pedidos_Prod>();
            Orden_Produccion_Detalle = new HashSet<Orden_Produccion_Detalle>();
            Orden_Produccion_Lotes = new HashSet<Orden_Produccion_Lotes>();
            Plan_Prod_Fechas_Partidas = new HashSet<Plan_Prod_Fechas_Partidas>();
            Revision_Calidad = new HashSet<Revision_Calidad>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Orden { get; set; }

        public int Clas_TProducto { get; set; }

        public int Clas_Producto { get; set; }

        public int Clas_TConcepto { get; set; }

        public int Clas_Concepto { get; set; }

        public int Familia_Concepto { get; set; }

        public int Numero_Receta { get; set; }

        public int Numero_Estatus { get; set; }

        public int Familia_Estatus { get; set; }

        [StringLength(50)]
        public string Lote { get; set; }

        public DateTime? Fecha { get; set; }

        public DateTime? Fecha_Conclusion { get; set; }

        public decimal Cantidad { get; set; }

        public int Numero_UMedida { get; set; }

        public int Familia_UMedida { get; set; }

        [StringLength(250)]
        public string Observaciones { get; set; }

        public int Usuario { get; set; }

        public int chk_GSolicitud { get; set; }

        public virtual Actualizacion_Controles Actualizacion_Controles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Almacen_Sol_Produccion> Almacen_Sol_Produccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avance_Orden_Produccion> Avance_Orden_Produccion { get; set; }

        public virtual Calculo_Rendimiento Calculo_Rendimiento { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }

        public virtual Clasificacion Clasificacion3 { get; set; }

        public virtual Clasificacion Clasificacion4 { get; set; }

        public virtual Clasificacion Clasificacion5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrega_Almacen_Prod> Entrega_Almacen_Prod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Liberacion_Pedidos_Prod> Liberacion_Pedidos_Prod { get; set; }

        public virtual Receta Receta { get; set; }

        public virtual Persona Persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orden_Produccion_Detalle> Orden_Produccion_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orden_Produccion_Lotes> Orden_Produccion_Lotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plan_Prod_Fechas_Partidas> Plan_Prod_Fechas_Partidas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Revision_Calidad> Revision_Calidad { get; set; }
    }
}
