namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Caja_Chica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Caja_Chica()
        {
            Caja_Chica_Caja_Concepto = new HashSet<Caja_Chica_Caja_Concepto>();
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

        public int Familia_Estatus { get; set; }

        public int Clas_Moneda { get; set; }

        public int Familia_Moneda { get; set; }

        public int? Cont_Clas_Caja { get; set; }

        public int Persona_Responsable { get; set; }

        public byte Afectacion_General { get; set; }

        public int Centro_Costo { get; set; }

        public int Familia_Centro_Costo { get; set; }

        public decimal Importe_Max { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja_Chica_Caja_Concepto> Caja_Chica_Caja_Concepto { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
