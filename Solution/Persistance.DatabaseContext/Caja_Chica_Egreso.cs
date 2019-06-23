namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Caja_Chica_Egreso
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

        [StringLength(500)]
        public string Motivo { get; set; }

        public decimal Importe { get; set; }

        [Required]
        [StringLength(180)]
        public string Persona_Asignado { get; set; }

        public int Clas_Moneda { get; set; }

        public int Usuario { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Fecha_Ingreso { get; set; }

        [StringLength(500)]
        public string Observacion { get; set; }

        public int? Familia { get; set; }

        public int Cancelado { get; set; }

        public decimal? Tipo_Cambio { get; set; }
    }
}
