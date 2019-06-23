namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Caja_Arqueo_Egresos_TMP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Usuario { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Egreso { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime Fecha { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string Num_Vale { get; set; }

        [StringLength(500)]
        public string Motivo { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal Importe { get; set; }

        [StringLength(100)]
        public string Folio { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(30)]
        public string Tipo { get; set; }

        public int? Numero_Comprobante { get; set; }

        public int? Marca { get; set; }
    }
}
