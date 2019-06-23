namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RH_Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RH_Persona()
        {
            CProyectos = new HashSet<CProyecto>();
            Transporte_Vehiculo = new HashSet<Transporte_Vehiculo>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Persona { get; set; }

        public int? Clas_depto { get; set; }

        public int? clas_Seccion { get; set; }

        public int? clas_Puesto { get; set; }

        public int? Turno { get; set; }

        public DateTime? h_ini1 { get; set; }

        public DateTime? h_Fin1 { get; set; }

        public int? Turno2 { get; set; }

        public DateTime? h_ini2 { get; set; }

        public DateTime? h_Fin2 { get; set; }

        [StringLength(10)]
        public string Turno3 { get; set; }

        public DateTime? h_ini3 { get; set; }

        public DateTime? h_Fin3 { get; set; }

        public int? Varios { get; set; }

        public short Familia { get; set; }

        [StringLength(20)]
        public string Numero_Empleado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CProyecto> CProyectos { get; set; }

        public virtual Empresa Empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transporte_Vehiculo> Transporte_Vehiculo { get; set; }
    }
}
