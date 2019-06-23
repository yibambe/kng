namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cc_Pagos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cc_Pagos()
        {
            cc_Pagos_Detalle = new HashSet<cc_Pagos_Detalle>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Pago { get; set; }

        public int Clas_Pantalla { get; set; }

        public DateTime Fecha_Pago { get; set; }

        public int? Numero_Anticipo { get; set; }

        public int? Numero_Mov_Banco { get; set; }

        public int? Numero_Mov_Caja { get; set; }

        public int Numero_Usuario { get; set; }

        [StringLength(50)]
        public string Poliza { get; set; }

        public virtual Persona Persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cc_Pagos_Detalle> cc_Pagos_Detalle { get; set; }
    }
}
