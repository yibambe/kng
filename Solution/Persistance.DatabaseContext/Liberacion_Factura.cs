namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Liberacion_Factura
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
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime Fecha { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tipo_Documento { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string Tipo { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cliente { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Folio { get; set; }
    }
}
