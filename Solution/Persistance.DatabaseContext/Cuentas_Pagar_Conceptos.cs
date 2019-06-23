namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cuentas_Pagar_Conceptos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cuentas_Pagar_Conceptos()
        {
            Cuentas_Pagar = new HashSet<Cuentas_Pagar>();
            cp_Proceso_Pago = new HashSet<cp_Proceso_Pago>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }

        public byte? Auxiliar { get; set; }

        public byte? Cheque { get; set; }

        public byte? Anticipo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cuentas_Pagar> Cuentas_Pagar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cp_Proceso_Pago> cp_Proceso_Pago { get; set; }
    }
}
