namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Caja_Arqueo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Caja_Arqueo()
        {
            Caja_Arqueo_Detalle = new HashSet<Caja_Arqueo_Detalle>();
            Caja_Arqueo_Efectivo = new HashSet<Caja_Arqueo_Efectivo>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Numero_Usuario { get; set; }

        public int Numero_Caja { get; set; }

        public DateTime Fecha { get; set; }

        public int Clas_Concepto { get; set; }

        public decimal Importe_Caja { get; set; }

        public decimal Diferencia { get; set; }

        [StringLength(600)]
        public string Observaciones { get; set; }

        public int Contabilizado { get; set; }

        public int Familia { get; set; }

        public virtual Caja Caja { get; set; }

        public virtual Usuario Usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Arqueo_Detalle> Caja_Arqueo_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Arqueo_Efectivo> Caja_Arqueo_Efectivo { get; set; }
    }
}
