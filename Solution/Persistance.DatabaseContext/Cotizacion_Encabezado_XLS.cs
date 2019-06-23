namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cotizacion_Encabezado_XLS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Numero_Cotizacion { get; set; }

        public DateTime? Fecha { get; set; }

        public DateTime? Fecha_Entrega { get; set; }

        public DateTime? Hora_De { get; set; }

        public DateTime? Hora_Hasta { get; set; }

        [StringLength(10)]
        public string Estatus { get; set; }

        [StringLength(100)]
        public string Cliente { get; set; }

        [StringLength(100)]
        public string Contacto { get; set; }

        [StringLength(100)]
        public string Responsable { get; set; }

        [StringLength(250)]
        public string Vendedor { get; set; }

        [StringLength(250)]
        public string Nombre_Proyecto { get; set; }

        [StringLength(100)]
        public string Moneda { get; set; }

        [StringLength(100)]
        public string Moneda_Facturar { get; set; }

        public int? Numero_Pagos { get; set; }

        [StringLength(100)]
        public string Periodicidad_Pagos { get; set; }

        public decimal? IVA { get; set; }

        public decimal? Descuento { get; set; }

        public decimal? Comision { get; set; }

        [StringLength(8000)]
        public string Texto_Factura { get; set; }

        [StringLength(8000)]
        public string Observaciones { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        [StringLength(100)]
        public string Contacto_Entrega { get; set; }

        [StringLength(50)]
        public string Domicilio_Entrega { get; set; }

        [StringLength(50)]
        public string Colonia_Entrega { get; set; }

        [StringLength(50)]
        public string Delegación_Entrega { get; set; }

        [StringLength(50)]
        public string Estado_Entrega { get; set; }

        [StringLength(50)]
        public string CP_Entrega { get; set; }

        [StringLength(50)]
        public string Telefono_Entrega { get; set; }

        public int? Numero { get; set; }

        public int? Numero_Ant { get; set; }
    }
}
