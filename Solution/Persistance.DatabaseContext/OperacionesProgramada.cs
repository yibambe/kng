namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OperacionesProgramada
    {
        public int? Numero { get; set; }

        [StringLength(10)]
        public string TipoOperacion { get; set; }

        [StringLength(10)]
        public string BancoCargo { get; set; }

        public int? CuentaCargo { get; set; }

        [StringLength(10)]
        public string BancoAbono { get; set; }

        public int? CuentaAbono { get; set; }

        [Column(TypeName = "money")]
        public decimal? Moneda { get; set; }

        [Column(TypeName = "money")]
        public decimal? Importe { get; set; }

        public DateTime? FechaHoraAplic { get; set; }

        [StringLength(10)]
        public string Estado { get; set; }

        [StringLength(50)]
        public string Referencia { get; set; }

        public int? Beneficiario { get; set; }

        public int? NumeroFactura { get; set; }

        public int? DigitoFactura { get; set; }

        public int? FolioCorte { get; set; }

        public int? FolioConfirmacion { get; set; }

        public DateTime? FechaConfirmacion { get; set; }

        [Key]
        public bool Exportado { get; set; }
    }
}
