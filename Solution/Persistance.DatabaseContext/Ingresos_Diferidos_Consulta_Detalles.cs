namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ingresos_Diferidos_Consulta_Detalles
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Usuario { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Año { get; set; }

        public decimal? Ene { get; set; }

        public decimal? Feb { get; set; }

        public decimal? Mar { get; set; }

        public decimal? Abr { get; set; }

        public decimal? May { get; set; }

        public decimal? Jun { get; set; }

        public decimal? Jul { get; set; }

        public decimal? Ago { get; set; }

        public decimal? Sep { get; set; }

        public decimal? Oct { get; set; }

        public decimal? Nov { get; set; }

        public decimal? Dic { get; set; }
    }
}
