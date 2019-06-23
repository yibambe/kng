namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ordene
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int? Remitente { get; set; }

        public int? DomicilioRemitente { get; set; }

        public int? Beneficiario { get; set; }

        public int? DomicilioBeneficiario { get; set; }

        public int? OficinaOrigen { get; set; }

        public int? OficinaDestino { get; set; }

        public int? Producto { get; set; }

        public int? MonedaOrigen { get; set; }

        [Column(TypeName = "money")]
        public decimal? ImporteOrigen { get; set; }

        [Column(TypeName = "money")]
        public decimal? ComisionCliente { get; set; }

        public int? MonedaDestino { get; set; }

        [Column(TypeName = "money")]
        public decimal? ImporteDestino { get; set; }

        public int? FolioCambio { get; set; }

        public int? MonedaCambio { get; set; }

        [Column(TypeName = "money")]
        public decimal? UtilidadCambiaria { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool TransferenciaConf { get; set; }

        [Column(TypeName = "ntext")]
        public string Comentarios { get; set; }

        public DateTime? FechaInicial { get; set; }

        public DateTime? FechaActualizacion { get; set; }

        public DateTime? FechaConfirmacion { get; set; }

        public DateTime? FechaFinal { get; set; }

        public int? UsuarioOrigen { get; set; }

        public int? UsuarioDestino { get; set; }

        [StringLength(10)]
        public string Estado { get; set; }

        [Column(TypeName = "money")]
        public decimal? ComisionOrigen { get; set; }

        [Column(TypeName = "money")]
        public decimal? ComisionDestino { get; set; }

        [StringLength(10)]
        public string Banco { get; set; }

        public int? Cuenta { get; set; }

        public int? FolioConfirmacion { get; set; }

        public int? FolioTransaccion { get; set; }

        public int? NumeroFactura { get; set; }

        public int? DigitoFactura { get; set; }

        public int? CambioBeneficiario { get; set; }

        public int? CambioDomicilio { get; set; }

        [Column(TypeName = "money")]
        public decimal? EfectivoEnvio { get; set; }

        [StringLength(10)]
        public string BancoCheque { get; set; }

        public int? CuentaCheque { get; set; }

        public int? NumeroCheque { get; set; }

        [Column(TypeName = "money")]
        public decimal? ImporteCheque { get; set; }

        [StringLength(21)]
        public string TipoAlerta { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Modificado { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool ModificarInstruccion { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool InformoAlCliente { get; set; }

        public DateTime? FechaVencimiento { get; set; }

        public int? FolioVencimiento { get; set; }

        public int? MotivoRechazo { get; set; }

        [StringLength(10)]
        public string TipoOperacion { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool DestinoPredeterminado { get; set; }

        [StringLength(20)]
        public string TipoIdentificacion { get; set; }

        [StringLength(20)]
        public string NumeroIdentificacion { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool CobrarComisionCambio { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool LiquidadaAgente { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool ComisionPagada { get; set; }

        public DateTime? Fechapagocom { get; set; }
    }
}
