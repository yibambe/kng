namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Produccion_Almacen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produccion_Almacen()
        {
            Produccion_Almacen_Detalle = new HashSet<Produccion_Almacen_Detalle>();
            Produccion_Salida_Almacen_Detalle = new HashSet<Produccion_Salida_Almacen_Detalle>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public DateTime Fecha { get; set; }

        public int Clas_Concepto { get; set; }

        public int Estatus { get; set; }

        public int Clas_Almacen { get; set; }

        [StringLength(50)]
        public string Num_Produccion { get; set; }

        [StringLength(50)]
        public string Num_Lote { get; set; }

        [StringLength(250)]
        public string Observaciones { get; set; }

        public int Usuario { get; set; }

        public int? Clas_Moneda { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public DateTime? Fecha_Cancelacion { get; set; }

        [StringLength(250)]
        public string Causa_Cancelacion { get; set; }

        public int Familia_Almacen { get; set; }

        public int Familia_Concepto { get; set; }

        public int Familia_Moneda { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produccion_Almacen_Detalle> Produccion_Almacen_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produccion_Salida_Almacen_Detalle> Produccion_Salida_Almacen_Detalle { get; set; }
    }
}
