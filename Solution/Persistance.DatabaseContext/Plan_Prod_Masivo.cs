namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Plan_Prod_Masivo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plan_Prod_Masivo()
        {
            Plan_Prod_Detalle_Masivo = new HashSet<Plan_Prod_Detalle_Masivo>();
            Plan_Prod_Periodos_Masivo = new HashSet<Plan_Prod_Periodos_Masivo>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Plan { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Fecha { get; set; }

        public int Clas_Estatus { get; set; }

        public int Familia_Estatus { get; set; }

        public int Mes_Inicial { get; set; }

        public int Anio_Inicial { get; set; }

        public int Mes_Final { get; set; }

        public int Anio_Final { get; set; }

        public byte? Mostrar { get; set; }

        public int? Usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plan_Prod_Detalle_Masivo> Plan_Prod_Detalle_Masivo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plan_Prod_Periodos_Masivo> Plan_Prod_Periodos_Masivo { get; set; }
    }
}
