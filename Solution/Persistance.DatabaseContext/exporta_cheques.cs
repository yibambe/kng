namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class exporta_cheques
    {
        public int? Numero { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string compania { get; set; }

        [StringLength(60)]
        public string nombre_compania { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string trabajador { get; set; }

        [StringLength(100)]
        public string nombre_trab { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime fecha_pago { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string banco { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(30)]
        public string chequera { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal importe { get; set; }

        [StringLength(300)]
        public string importe_letra { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int concepto_neto { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short no_recibo { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(10)]
        public string Agrupacion { get; set; }

        [StringLength(40)]
        public string Desc_Agr { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(10)]
        public string Dato { get; set; }

        [StringLength(40)]
        public string Desc_Dato { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(10)]
        public string Referencia { get; set; }

        public int? Impreso { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(10)]
        public string agr_desarrollo { get; set; }

        [StringLength(40)]
        public string desc_agr_des { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(10)]
        public string dato_desarrollo { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(40)]
        public string desc_dato_des { get; set; }

        public int? forma_pago { get; set; }

        [StringLength(40)]
        public string desc_forma_pago { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(10)]
        public string Plaza { get; set; }

        public int? Numero_Empresa { get; set; }

        [StringLength(50)]
        public string Folio_Cheque { get; set; }

        public int? Num_Banco { get; set; }

        public int? Num_Clas_Cuenta { get; set; }

        public byte? Tipo_Contabilidad { get; set; }

        public int? Numero_Movimiento { get; set; }

        public int? Numero_CP { get; set; }
    }
}
