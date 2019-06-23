namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Notas_Credito_Compras
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_OC { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Fact { get; set; }

        [Required]
        [StringLength(20)]
        public string Factura { get; set; }

        public int Moneda { get; set; }

        public short Familia_Moneda { get; set; }

        public decimal Fecha_NC { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Numero_Documento_NC { get; set; }

        public decimal Importe { get; set; }

        public decimal Tipo_Cambio { get; set; }
    }
}
