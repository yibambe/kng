namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Descuento_Concepto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Descuento_Concepto()
        {
            Lista_Precios_Detalle = new HashSet<Lista_Precios_Detalle>();
            Lista_Precios_Detalle_TMP = new HashSet<Lista_Precios_Detalle_TMP>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [StringLength(80)]
        public string Descripcion { get; set; }

        public bool Factura { get; set; }

        public bool Porcentaje { get; set; }

        public bool Rango { get; set; }

        public bool Fecha { get; set; }

        public byte Tipo { get; set; }

        public decimal? Importe { get; set; }

        public DateTime? Fecha_Vencimiento { get; set; }

        public decimal? Hasta { get; set; }

        public int? Tipo_Cliente { get; set; }

        public int? Familia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lista_Precios_Detalle> Lista_Precios_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lista_Precios_Detalle_TMP> Lista_Precios_Detalle_TMP { get; set; }
    }
}
