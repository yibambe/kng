namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Caja_Corte
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
        public int Banco { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Cuenta { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime Fecha { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime Hora { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1000)]
        public string Referencia { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Concepto { get; set; }

        public decimal Importe { get; set; }

        public int? Numero_Registro_Banco { get; set; }

        public int? Usuario { get; set; }

        public decimal? tipo_cambio { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
