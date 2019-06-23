namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bancos_Movimientos_Multiples
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Deposito_Retiro { get; set; }

        public DateTime Fecha { get; set; }

        public byte Estatus { get; set; }

        public int Numero_Banco { get; set; }

        public int Clas_Cuenta { get; set; }

        public int Clas_Concepto { get; set; }

        [Required]
        [StringLength(160)]
        public string Titulo_Poliza { get; set; }

        public byte Contabilizado { get; set; }

        public int? Numero_Reg_Poliza { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public int Familia { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Cancelacion { get; set; }

        [StringLength(1000)]
        public string Causa { get; set; }

        public int? Usuario_Cancela { get; set; }
    }
}
