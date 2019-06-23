namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChequerasBanco")]
    public partial class ChequerasBanco
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Banco { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumeroCuenta { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        public int? Moneda { get; set; }

        public int? UltimoCheque { get; set; }

        [StringLength(10)]
        public string Estado { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool DepositoCuenta { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool ConfirDeposito { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool OrdenPago { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool ConfirOrden { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool Conciliacion { get; set; }

        [StringLength(50)]
        public string RutaConciliacion { get; set; }

        public int? Plaza { get; set; }

        [StringLength(10)]
        public string Sucursal { get; set; }

        public int? DigitoIntercambiario { get; set; }

        public int? Empresa { get; set; }

        public int? auxiliar { get; set; }

        public int? Beneficiario { get; set; }

        public int? Complejo { get; set; }
    }
}
