namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Factura_Interface_XLS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int? Numero_Cliente { get; set; }

        public int? Num_Domicilio { get; set; }

        public int? Factura_Concepto { get; set; }

        public int? Clas_Centro_Costo { get; set; }

        public DateTime? Fecha { get; set; }

        public int? Moneda_Cotiza { get; set; }

        public int? Moneda_Factura { get; set; }

        public int? Iva { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public int? Familia_Moneda { get; set; }

        public int? Familia_Cont { get; set; }

        public int? Usuario { get; set; }

        public byte? Tipo { get; set; }

        public byte? Estatus { get; set; }

        [StringLength(250)]
        public string Observaciones { get; set; }
    }
}
