namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Numero_ID_Consulta
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Pantalla { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Usuario { get; set; }

        public int? Numero_ID1 { get; set; }

        public int? Numero_ID2 { get; set; }

        public int? Numero_ID3 { get; set; }

        public int? Numero_ID4 { get; set; }

        public int? Numero_ID5 { get; set; }

        public decimal? NDecimal_ID1 { get; set; }

        public decimal? NDecimal_ID2 { get; set; }

        public decimal? NDecimal_ID3 { get; set; }

        public decimal? NDecimal_ID4 { get; set; }

        public decimal? NDecimal_ID5 { get; set; }

        [StringLength(50)]
        public string Cadena { get; set; }

        public DateTime? Fecha1 { get; set; }

        public DateTime? Fecha2 { get; set; }

        public int? NProceso { get; set; }
    }
}
