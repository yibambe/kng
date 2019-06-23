namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Programa")]
    public partial class Programa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Programa()
        {
            Autoriza_Perfil_Pantalla = new HashSet<Autoriza_Perfil_Pantalla>();
            Facultades_extraordinarias = new HashSet<Facultades_extraordinarias>();
            Perfil_programa = new HashSet<Perfil_programa>();
        }

        public short? Nivel { get; set; }

        public int? Clasificacion { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [StringLength(250)]
        public string Nombre_programa { get; set; }

        [StringLength(250)]
        public string Tipo_programa { get; set; }

        [StringLength(250)]
        public string Observaciones { get; set; }

        public int? Horas_estimadas_desarrollo { get; set; }

        public int? Programador { get; set; }

        public bool? Menu { get; set; }

        public bool? Mantenimiento { get; set; }

        public bool? Seguridad { get; set; }

        [StringLength(1)]
        public string Estatus { get; set; }

        public DateTime? Finicial_plan { get; set; }

        public DateTime? FFinal_plan { get; set; }

        public DateTime? FInicial_real { get; set; }

        public DateTime? FFinal_real { get; set; }

        public int? Orden_desarrollo { get; set; }

        public int? Numero_tipo_documento { get; set; }

        public bool Contabilidad { get; set; }

        public short? Familia_Clasificacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autoriza_Perfil_Pantalla> Autoriza_Perfil_Pantalla { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facultades_extraordinarias> Facultades_extraordinarias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Perfil_programa> Perfil_programa { get; set; }
    }
}
