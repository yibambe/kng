namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cuentas_Cobrar_Conceptos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cuentas_Cobrar_Conceptos()
        {
            Cuentas_Cobrar = new HashSet<Cuentas_Cobrar>();
            cc_Proceso_Pago = new HashSet<cc_Proceso_Pago>();
            Cuentas_Cobrar_Conceptos_Pantalla = new HashSet<Cuentas_Cobrar_Conceptos_Pantalla>();
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

        public byte? Tiendas { get; set; }

        public int? Clas_Auxiliar_Conta { get; set; }

        public int? Clas_Moneda { get; set; }

        public byte? Cambio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cuentas_Cobrar> Cuentas_Cobrar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cc_Proceso_Pago> cc_Proceso_Pago { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cuentas_Cobrar_Conceptos_Pantalla> Cuentas_Cobrar_Conceptos_Pantalla { get; set; }
    }
}
