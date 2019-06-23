namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Historico_Produccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Historico_Produccion()
        {
            Historico_Prod_Detalle = new HashSet<Historico_Prod_Detalle>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Historico { get; set; }

        public int Numero_Operacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Folio { get; set; }

        public int? Numero_Pedido { get; set; }

        public int? Numero_Factura { get; set; }

        public int Numero_Cliente { get; set; }

        public int Clas_Moneda { get; set; }

        public int Familia_Moneda { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Emision { get; set; }

        public int Clas_Iva { get; set; }

        public int Familia_Iva { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public decimal? SubTotal { get; set; }

        public decimal? Monto_Descuento { get; set; }

        public decimal? Monto_Iva { get; set; }

        public decimal? Monto_Total { get; set; }

        [StringLength(1000)]
        public string Importe_Letra { get; set; }

        public int? Estatus { get; set; }

        public int Contabilizada { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Cancelacion { get; set; }

        public int? Usuario_Cancelacion { get; set; }

        [StringLength(1000)]
        public string Causa_Cancelacion { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historico_Prod_Detalle> Historico_Prod_Detalle { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Persona Persona1 { get; set; }
    }
}
