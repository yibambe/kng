namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Caja")]
    public partial class Caja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Caja()
        {
            Caja_Arqueo = new HashSet<Caja_Arqueo>();
            Caja_Concepto = new HashSet<Caja_Concepto>();
            Caja_Concepto1 = new HashSet<Caja_Concepto>();
            Caja_Detalle = new HashSet<Caja_Detalle>();
            Caja_Dotacion = new HashSet<Caja_Dotacion>();
            Caja_Egreso = new HashSet<Caja_Egreso>();
            Caja_Solicitud_Reembolso = new HashSet<Caja_Solicitud_Reembolso>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Required]
        [StringLength(200)]
        public string Caja_Descripcion { get; set; }

        public int Clas_Estatus { get; set; }

        public int Clas_Moneda { get; set; }

        public int Cont_Clas_Caja { get; set; }

        public int Cont_Clas_Caja_Deudores_Caja { get; set; }

        public int? Familia_Estatus { get; set; }

        public int? Familia_Moneda { get; set; }

        public int? Persona_Responsable { get; set; }

        public byte? Afectacion_General { get; set; }

        public int? Centro_Costo { get; set; }

        public int? Familia_Centro_Costo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Arqueo> Caja_Arqueo { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Concepto> Caja_Concepto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Concepto> Caja_Concepto1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Detalle> Caja_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Dotacion> Caja_Dotacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Egreso> Caja_Egreso { get; set; }

        public virtual Empresa Empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Solicitud_Reembolso> Caja_Solicitud_Reembolso { get; set; }
    }
}
