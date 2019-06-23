namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Taller_Impuestos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Taller_Impuestos()
        {
            Articulo_Concepto_Impuesto = new HashSet<Articulo_Concepto_Impuesto>();
            Historico_Articulo_Concepto_Impuesto = new HashSet<Historico_Articulo_Concepto_Impuesto>();
            Producto_Impuesto = new HashSet<Producto_Impuesto>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(1)]
        public string Operacion { get; set; }

        public bool Porcentaje { get; set; }

        public bool Suma_Subtotal { get; set; }

        [StringLength(25)]
        public string c_Impuesto_Clave { get; set; }

        public byte? Tipo_Persona { get; set; }

        public int? Concepto_Contable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Articulo_Concepto_Impuesto> Articulo_Concepto_Impuesto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historico_Articulo_Concepto_Impuesto> Historico_Articulo_Concepto_Impuesto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto_Impuesto> Producto_Impuesto { get; set; }
    }
}
