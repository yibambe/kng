namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Caja_Comprobacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Caja_Comprobacion()
        {
            Caja_Dotacion_Comprobacion = new HashSet<Caja_Dotacion_Comprobacion>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Egreso { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(100)]
        public string Folio { get; set; }

        [StringLength(500)]
        public string Proveedor { get; set; }

        public int? Num_Proveedor { get; set; }

        public decimal Importe { get; set; }

        public int Clas_Iva { get; set; }

        public decimal Iva { get; set; }

        public int Clas_Retencion { get; set; }

        public decimal Retencion { get; set; }

        public decimal Propina { get; set; }

        public int Clas_Estatus { get; set; }

        public int Contabilizado { get; set; }

        public int? Costo { get; set; }

        public int? Clas_Depto { get; set; }

        public int? Clas_Cuenta { get; set; }

        public int Clas_Concepto { get; set; }

        public int Usuario { get; set; }

        public int Familia_Iva_Retencion { get; set; }

        public int Padre_Iva { get; set; }

        public int Padre_Retencion { get; set; }

        public int Familia_Estatus_Cuenta { get; set; }

        public int Familia_Departamento { get; set; }

        public int Padre_Departamento { get; set; }

        public int? Prorrateo { get; set; }

        public virtual Caja_Egreso Caja_Egreso { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }

        public virtual Clasificacion Clasificacion3 { get; set; }

        public virtual Usuario Usuario1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Dotacion_Comprobacion> Caja_Dotacion_Comprobacion { get; set; }
    }
}
