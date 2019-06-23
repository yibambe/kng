namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orden_Compras_Encabezado_XLS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Numero_OC { get; set; }

        [StringLength(50)]
        public string Numero_Cotizacion { get; set; }

        public DateTime? Fecha { get; set; }

        public DateTime? Fecha_Entrega { get; set; }

        [StringLength(10)]
        public string Estatus { get; set; }

        [StringLength(100)]
        public string Proveedor { get; set; }

        [StringLength(100)]
        public string Solicitante { get; set; }

        [StringLength(100)]
        public string Moneda { get; set; }

        public int? Numero_Pagos { get; set; }

        [StringLength(100)]
        public string Periodicidad_Pagos { get; set; }

        public decimal? IVA { get; set; }

        public decimal? Descuento { get; set; }

        public decimal? Comision { get; set; }

        [StringLength(10)]
        public string Tipo_Entrega { get; set; }

        [StringLength(100)]
        public string Persona_Entrega { get; set; }

        [StringLength(100)]
        public string Almacen { get; set; }

        [StringLength(2000)]
        public string Observaciones { get; set; }

        public int? Numero { get; set; }

        public int? Numero_Ant { get; set; }
    }
}
