namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Caja_Chica_Dotacion
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Caja { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Fecha { get; set; }

        public int Clas_Concepto { get; set; }

        public int Forma_Asignacion { get; set; }

        public int Moneda { get; set; }

        public decimal Importe { get; set; }

        public int? Numero_Banco { get; set; }

        public int? Clas_Cuenta { get; set; }

        [StringLength(100)]
        public string Folio { get; set; }

        public int? Numero_Beneficiario { get; set; }

        [StringLength(500)]
        public string Observaciones { get; set; }

        public int Usuario { get; set; }

        public int? Numero_Reg_Mov_Chequeras { get; set; }

        public int Cancelado { get; set; }

        public int Familia { get; set; }

        public virtual Bancos_Registro_Movimiento Bancos_Registro_Movimiento { get; set; }

        public virtual Usuario Usuario1 { get; set; }
    }
}
