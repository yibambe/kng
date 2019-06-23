namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CorteOficinaUsuario")]
    public partial class CorteOficinaUsuario
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Oficina { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Usuario { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Folio { get; set; }

        public DateTime? FechaHoraInicio { get; set; }

        public DateTime? FechaHoraCorte { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Abierta { get; set; }

        public int? ReferenciaEfectivo { get; set; }

        [Column(TypeName = "money")]
        public decimal? ImporteEfectivo { get; set; }

        public int? ReferenciaCheques { get; set; }

        [Column(TypeName = "money")]
        public decimal? ImporteCheques { get; set; }

        [Column(TypeName = "money")]
        public decimal? OrdenesPagadas { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool Liquidadas { get; set; }

        public int? Moneda { get; set; }

        [Column(TypeName = "money")]
        public decimal? PagoAgente { get; set; }
    }
}
