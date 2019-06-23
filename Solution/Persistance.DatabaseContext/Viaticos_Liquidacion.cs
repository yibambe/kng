namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Viaticos_Liquidacion
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
        public int Numero { get; set; }

        public short Tipo { get; set; }

        public short Estatus { get; set; }

        public int Moneda_Origen { get; set; }

        public DateTime Fecha { get; set; }

        public int? Contabilizado { get; set; }

        public DateTime? Fecha_Cancelacion { get; set; }

        [StringLength(1024)]
        public string Causa { get; set; }

        public int? Persona_Cancela { get; set; }

        public DateTime? Fecha_Contabilizada { get; set; }

        public int Familia_Moneda { get; set; }

        public decimal? Importe_Total_MN { get; set; }
    }
}
