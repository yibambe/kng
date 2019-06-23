namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AuxMovChequerasNC")]
    public partial class AuxMovChequerasNC
    {
        [StringLength(10)]
        public string Banco { get; set; }

        public int? NumeroCuenta { get; set; }

        public int? Folio { get; set; }

        [StringLength(1050)]
        public string Concepto { get; set; }

        [Column(TypeName = "money")]
        public decimal? Importe { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FechaMov { get; set; }

        [StringLength(100)]
        public string Referencia { get; set; }

        [Key]
        public bool Conciliado { get; set; }

        [StringLength(50)]
        public string NombreBanco { get; set; }

        [StringLength(50)]
        public string NombreCuenta { get; set; }

        [StringLength(10)]
        public string Tipo { get; set; }

        [StringLength(50)]
        public string Titulo { get; set; }
    }
}
