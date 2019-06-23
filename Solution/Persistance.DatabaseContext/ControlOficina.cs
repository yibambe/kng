namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ControlOficina")]
    public partial class ControlOficina
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clasificacion { get; set; }

        public int? Tipo { get; set; }

        [StringLength(10)]
        public string Estatus { get; set; }

        [StringLength(50)]
        public string Calle { get; set; }

        [StringLength(50)]
        public string Colonia { get; set; }

        [StringLength(50)]
        public string Ciudad { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        [StringLength(5)]
        public string CodigoPostal { get; set; }

        [StringLength(10)]
        public string BancoDeposito { get; set; }

        public int? CuentaDeposito { get; set; }

        [StringLength(10)]
        public string BancoConcentracion { get; set; }

        public int? CuentaConcentracion { get; set; }

        [StringLength(10)]
        public string BancoPago { get; set; }

        public int? CuentaPago { get; set; }

        [StringLength(10)]
        public string BancoDispersion { get; set; }

        public int? CuentaDispersion { get; set; }

        [StringLength(10)]
        public string TipoComisiones { get; set; }

        [StringLength(10)]
        public string CategoriaCompetencia { get; set; }

        [StringLength(10)]
        public string CategoriaZona { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool PermitirCorteParcial { get; set; }

        public int? OficinaResponsable { get; set; }

        [StringLength(10)]
        public string Banco { get; set; }

        public int? Sucursal { get; set; }

        [Column(TypeName = "money")]
        public decimal? ImporteFijoPago { get; set; }

        [StringLength(1)]
        public string PermitirCheques { get; set; }

        public int? PorsPermitido { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Abierta { get; set; }

        public DateTime? FechaUltimoCorte { get; set; }
    }
}
