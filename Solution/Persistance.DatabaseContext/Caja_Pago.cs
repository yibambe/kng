namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Caja_Pago
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Numero_Caja_Egreso { get; set; }

        public decimal Importe { get; set; }

        [Required]
        [StringLength(50)]
        public string Num_Comprobante { get; set; }

        public int Clas_Concepto { get; set; }

        public DateTime Fecha { get; set; }

        public int? Usuario { get; set; }

        public int? Facturado { get; set; }

        public int? Tipo_Docto { get; set; }

        public int? Num_Docto { get; set; }

        public int Familia { get; set; }

        public int Familia_Docto { get; set; }
    }
}
