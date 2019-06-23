namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Plan_Prod_Fechas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plan_Prod_Fechas()
        {
            Plan_Prod_Fechas_Partidas = new HashSet<Plan_Prod_Fechas_Partidas>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int? Numero_Plan { get; set; }

        public int Clasificacion_TProducto { get; set; }

        public int Clasificacion_Producto { get; set; }

        public int Clasificacion_TConcepto { get; set; }

        public int Clasificacion_Concepto { get; set; }

        public int Familia_Concepto { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Fecha { get; set; }

        public DateTime? Fecha_Programada { get; set; }

        public decimal Cantidad { get; set; }

        public DateTime? Fecha_Entrega { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }

        public virtual Clasificacion Clasificacion3 { get; set; }

        public virtual Plan_Produccion Plan_Produccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plan_Prod_Fechas_Partidas> Plan_Prod_Fechas_Partidas { get; set; }
    }
}
