namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Familia")]
    public partial class Familia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Familia()
        {
            Clasificacions = new HashSet<Clasificacion>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        public bool? Nivel_fijo { get; set; }

        public short? Niveles { get; set; }

        [StringLength(50)]
        public string Nivel1 { get; set; }

        [StringLength(10)]
        public string Tipo1 { get; set; }

        public short? Lon1 { get; set; }

        [StringLength(50)]
        public string Nivel2 { get; set; }

        [StringLength(10)]
        public string Tipo2 { get; set; }

        public short? Lon2 { get; set; }

        [StringLength(50)]
        public string Nivel3 { get; set; }

        [StringLength(10)]
        public string Tipo3 { get; set; }

        public short? Lon3 { get; set; }

        [StringLength(50)]
        public string Nivel4 { get; set; }

        [StringLength(10)]
        public string Tipo4 { get; set; }

        public short? Lon4 { get; set; }

        [StringLength(50)]
        public string Nivel5 { get; set; }

        [StringLength(10)]
        public string Tipo5 { get; set; }

        public short? Lon5 { get; set; }

        [StringLength(50)]
        public string Nivel6 { get; set; }

        [StringLength(10)]
        public string Tipo6 { get; set; }

        public short? Lon6 { get; set; }

        [StringLength(50)]
        public string Nivel7 { get; set; }

        [StringLength(10)]
        public string Tipo7 { get; set; }

        public short? Lon7 { get; set; }

        [StringLength(50)]
        public string Nivel8 { get; set; }

        [StringLength(10)]
        public string Tipo8 { get; set; }

        public short? Lon8 { get; set; }

        [StringLength(50)]
        public string Nivel9 { get; set; }

        [StringLength(10)]
        public string Tipo9 { get; set; }

        public int? Lon9 { get; set; }

        public int? Perfil { get; set; }

        public bool Familia_Sistema { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clasificacion> Clasificacions { get; set; }

        public virtual Empresa Empresa1 { get; set; }
    }
}
