namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ks_Pedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ks_Pedido()
        {
            ks_Pedido_Detalle = new HashSet<ks_Pedido_Detalle>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cotiza { get; set; }

        public int Estatus_Credito { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Hora { get; set; }

        public int Numero_Vendedor { get; set; }

        [StringLength(100)]
        public string Solicitante { get; set; }

        public decimal Monto_Importe { get; set; }

        public decimal? Monto_Descuento { get; set; }

        public decimal Monto_Subtotal { get; set; }

        public decimal Monto_IVA { get; set; }

        public decimal Monto_Total { get; set; }

        [StringLength(1020)]
        public string Total_Letra { get; set; }

        public virtual Persona Persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ks_Pedido_Detalle> ks_Pedido_Detalle { get; set; }

        public virtual ks_Pedido_Entrega ks_Pedido_Entrega { get; set; }
    }
}
