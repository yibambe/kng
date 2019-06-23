namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orden_Compras_Detalle_Impuesto
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
        public byte Tipo1 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num_Impuesto { get; set; }

        [Required]
        [StringLength(1)]
        public string Operacion { get; set; }

        public bool Porcentaje { get; set; }

        public bool Suma_Subtotal { get; set; }

        public decimal Valor { get; set; }

        public decimal? Importe { get; set; }
    }
}
