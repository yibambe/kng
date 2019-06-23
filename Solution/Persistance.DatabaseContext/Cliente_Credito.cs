namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cliente_Credito
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cliente { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Moneda { get; set; }

        public decimal? Limite { get; set; }

        public int? Dias { get; set; }

        public decimal? Sobre_Giro { get; set; }

        public DateTime? Vigencia_De { get; set; }

        public DateTime? Vigencia_Hasta { get; set; }

        public byte? Familia { get; set; }

        public int? Usuario { get; set; }

        public int? Periodo_Gracia { get; set; }

        public byte? Contado { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
