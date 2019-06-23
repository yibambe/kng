namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoOficina")]
    public partial class TipoOficina
    {
        [Key]
        [Column("TipoOficina", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TipoOficina1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Empresa { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Pais { get; set; }

        public int? Puntos { get; set; }

        public int? Moneda { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cancelacion { get; set; }

        [Column(TypeName = "money")]
        public decimal? CambioInstruccion { get; set; }

        [Column(TypeName = "money")]
        public decimal? Reenvio { get; set; }

        [StringLength(10)]
        public string Estatus { get; set; }
    }
}
