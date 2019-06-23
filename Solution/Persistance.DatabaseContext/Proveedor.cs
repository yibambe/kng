namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Proveedor")]
    public partial class Proveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proveedor()
        {
            Articulo_proveedor = new HashSet<Articulo_proveedor>();
            Contacto_Proveedor = new HashSet<Contacto_Proveedor>();
            Cuentas_Pagar = new HashSet<Cuentas_Pagar>();
            Relacion_Cliente_Proveedor = new HashSet<Relacion_Cliente_Proveedor>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_persona { get; set; }

        public int? Clasificacion_proveedor { get; set; }

        public DateTime? Fecha_alta { get; set; }

        public int? Estatus { get; set; }

        [Column(TypeName = "text")]
        public string Observaciones { get; set; }

        public int? Cont_Clas_Proveedor { get; set; }

        public int? Cont_Clas_Proveedor_Activo { get; set; }

        public short Familia { get; set; }

        public short? Tipo { get; set; }

        public int? Cont_Clas_Acreedor { get; set; }

        public short? Forma_Pago { get; set; }

        public int? Clas_Forma_Pago { get; set; }

        public int? Clas_Moneda { get; set; }

        public int? Familia_Moneda { get; set; }

        public byte? Tipo_NE { get; set; }

        public int? Cont_Clas_Deudor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Articulo_proveedor> Articulo_proveedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contacto_Proveedor> Contacto_Proveedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cuentas_Pagar> Cuentas_Pagar { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual Persona Persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relacion_Cliente_Proveedor> Relacion_Cliente_Proveedor { get; set; }
    }
}
