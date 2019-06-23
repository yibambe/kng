namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovChequera")]
    public partial class MovChequera
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Banco { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumeroCuenta { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Folio { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string Concepto { get; set; }

        [Column(TypeName = "money")]
        public decimal? Importe { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FechaMov { get; set; }

        [StringLength(50)]
        public string Referencia { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool Conciliado { get; set; }

        public int? Usuario { get; set; }

        public int? Oficina { get; set; }

        public DateTime? FechaHora { get; set; }

        [Column(TypeName = "ntext")]
        public string Descripcion { get; set; }

        public int? Beneficiario { get; set; }
    }
}
