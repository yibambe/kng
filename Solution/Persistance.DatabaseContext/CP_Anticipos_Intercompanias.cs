namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CP_Anticipos_Intercompanias
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Empresa_Origen { get; set; }

        public int Banco_Origen { get; set; }

        public int Clas_Cuenta_Origen { get; set; }

        public int Moneda_Origen { get; set; }

        public int Concepto_Origen { get; set; }

        public int Bancos_Reg_Mov_Origen { get; set; }

        public int CPA_Reg { get; set; }

        public int Empresa_Destino { get; set; }

        public int Banco_Destino { get; set; }

        public int Clas_Cuenta_Destino { get; set; }

        public int Moneda_Destino { get; set; }

        public int Concepto_Destino { get; set; }

        public int Bancos_Reg_Mov_Destino { get; set; }

        public int CCA_Reg { get; set; }

        [Required]
        [StringLength(100)]
        public string Folio { get; set; }

        public decimal Importe { get; set; }

        public decimal Tipo_Cambio { get; set; }

        public DateTime Fecha { get; set; }

        public int Usuario { get; set; }

        public byte Tipo { get; set; }

        public int IVA { get; set; }

        public int Familia_Cuenta { get; set; }

        public int Familia_Moneda { get; set; }

        public int Familia_IVA { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Cancelacion { get; set; }

        [StringLength(1000)]
        public string Causa { get; set; }

        public int? Usuario_Cancela { get; set; }
    }
}
