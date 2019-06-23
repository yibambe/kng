namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Viaticos_Comprobantes
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Solicitud { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tipo { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime Fecha { get; set; }

        public int? Cantidad { get; set; }

        public decimal? Importe { get; set; }

        public byte? Familia { get; set; }

        public int? Numero { get; set; }

        public int? Estatus { get; set; }

        [StringLength(1024)]
        public string Observaciones { get; set; }

        public int? Usuario { get; set; }
    }
}
