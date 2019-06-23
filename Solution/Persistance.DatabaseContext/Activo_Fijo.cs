namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Activo_Fijo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Activo_Fijo()
        {
            Activo_Fijo_Depreciacion = new HashSet<Activo_Fijo_Depreciacion>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Clas_Activo { get; set; }

        public DateTime Fecha_Adquicicion { get; set; }

        public DateTime Fecha_Alta { get; set; }

        [StringLength(1024)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        public string Num_Inventario { get; set; }

        public decimal Valor_Adquicicion { get; set; }

        public int? Num_Meses_Depreciacion_Fiscal { get; set; }

        public int Num_Meses_Depreciacion_Contable { get; set; }

        public int? Porc_Depreciacion_Fiscal { get; set; }

        public int Porc_Depreciacion_Contable { get; set; }

        public DateTime Fecha_Inicio_Depreciacion { get; set; }

        public int Usuario { get; set; }

        public int Familia_Activo_Fijo { get; set; }

        public int Familia_Porcentajes_Iva { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activo_Fijo_Depreciacion> Activo_Fijo_Depreciacion { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
