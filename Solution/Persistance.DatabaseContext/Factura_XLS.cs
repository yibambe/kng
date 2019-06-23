namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Factura_XLS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num_Cliente { get; set; }

        public int? Domicilio { get; set; }

        public int? Contacto { get; set; }

        public DateTime? F_Emision { get; set; }

        public DateTime? F_Vencimiento { get; set; }

        public int? Tipo_Docto { get; set; }

        public int? Serie { get; set; }

        [StringLength(50)]
        public string Num_Docto { get; set; }

        [StringLength(50)]
        public string Referencia { get; set; }

        public int? Forma_Pago { get; set; }

        public int? Moneda { get; set; }

        public int? Clas_Iva { get; set; }

        public int? Clas_Concepto { get; set; }

        [StringLength(100)]
        public string Observaciones { get; set; }

        public int? Tipo { get; set; }

        public int? Producto { get; set; }

        public int? Concepto { get; set; }

        [StringLength(5000)]
        public string Caracteristicas { get; set; }

        public DateTime? Fecha_Entrega { get; set; }

        public decimal? Cantidad { get; set; }

        public decimal? Precio { get; set; }

        public decimal? TC { get; set; }

        public int? Usuario { get; set; }
    }
}
