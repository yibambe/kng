namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Nota_Credito_Detalle_Impuesto
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Nota_Credito { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Partida { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num_Impuesto { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string Operacion { get; set; }

        [Key]
        [Column(Order = 5)]
        public byte Porcentaje { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal Valor { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal Importe { get; set; }
    }
}
