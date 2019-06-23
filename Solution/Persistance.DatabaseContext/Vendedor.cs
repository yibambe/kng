namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vendedor")]
    public partial class Vendedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vendedor()
        {
            Cliente_Vendedor = new HashSet<Cliente_Vendedor>();
            Vendedor_Comision_Producto = new HashSet<Vendedor_Comision_Producto>();
            Vendedor_TipoCliente = new HashSet<Vendedor_TipoCliente>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Persona { get; set; }

        public int? Estatus { get; set; }

        public int? Forma_Pago { get; set; }

        public int? Periodo_pago { get; set; }

        public int? Zona_Asignada { get; set; }

        public int? Tipo_Pago { get; set; }

        public int? Cont_Clas_Vendedor { get; set; }

        public short Familia_Estatus_FyTPago_Zona_Tipo { get; set; }

        public short Familia_Periodo_Pago { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente_Vendedor> Cliente_Vendedor { get; set; }

        public virtual Persona Persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vendedor_Comision_Producto> Vendedor_Comision_Producto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vendedor_TipoCliente> Vendedor_TipoCliente { get; set; }
    }
}
