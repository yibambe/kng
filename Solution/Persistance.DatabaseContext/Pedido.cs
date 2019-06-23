namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pedido")]
    public partial class Pedido
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int? Numero_Cliente { get; set; }

        public int? Numero_Usuario { get; set; }

        public int? Numero_Vendedor { get; set; }

        public int? Numero_Forma_Entrega { get; set; }

        public int? Numero_Domiciilio_Entrega { get; set; }

        [StringLength(10)]
        public string Numero_Estatus { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(250)]
        public string Observaciones { get; set; }
    }
}
