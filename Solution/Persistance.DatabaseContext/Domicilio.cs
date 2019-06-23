namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Domicilio")]
    public partial class Domicilio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Domicilio()
        {
            ks_Pedido_Entrega = new HashSet<ks_Pedido_Entrega>();
            Sucursals = new HashSet<Sucursal>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int? Numero_Persona { get; set; }

        [Column("Domicilio")]
        [StringLength(100)]
        public string Domicilio1 { get; set; }

        [StringLength(50)]
        public string Colonia { get; set; }

        [StringLength(50)]
        public string Delegacion_municipio { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        [StringLength(5)]
        public string Codigo_postal { get; set; }

        [StringLength(64)]
        public string Telefono { get; set; }

        [StringLength(64)]
        public string Fax { get; set; }

        public bool Fiscal { get; set; }

        public int? Num_Domicilio_Persona { get; set; }

        public int? Tipo_Domicilio_Clasificacion { get; set; }

        public short Familia { get; set; }

        public int? Clas_Pais { get; set; }

        public int? Familia_Pais { get; set; }

        public virtual Persona Persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ks_Pedido_Entrega> ks_Pedido_Entrega { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sucursal> Sucursals { get; set; }
    }
}
