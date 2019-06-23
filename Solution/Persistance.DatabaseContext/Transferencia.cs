namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transferencia
    {
        public int? Folio { get; set; }

        [StringLength(10)]
        public string Banco { get; set; }

        public int? Cuenta { get; set; }

        [Column(TypeName = "money")]
        public decimal? ImporteSol { get; set; }

        [Column(TypeName = "money")]
        public decimal? ImporteReq { get; set; }

        public int? MonedaOrigen { get; set; }

        public int? MonedaDestino { get; set; }

        [Column(TypeName = "money")]
        public decimal? ImporteDestino { get; set; }

        [Key]
        public bool Procesado { get; set; }

        [Column(TypeName = "money")]
        public decimal? UtilidadCambiaria { get; set; }

        public int? MonedaCambio { get; set; }
    }
}
