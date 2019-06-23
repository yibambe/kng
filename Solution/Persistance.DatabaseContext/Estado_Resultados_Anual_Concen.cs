namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Estado_Resultados_Anual_Concen
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Usuario { get; set; }

        [StringLength(80)]
        public string Numero_Tipo_Cuenta { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Cuenta { get; set; }

        [StringLength(80)]
        public string Descripcion { get; set; }

        public decimal? Enero { get; set; }

        public decimal? Febrero { get; set; }

        public decimal? Marzo { get; set; }

        public decimal? Abril { get; set; }

        public decimal? Mayo { get; set; }

        public decimal? Junio { get; set; }

        public decimal? Julio { get; set; }

        public decimal? Agosto { get; set; }

        public decimal? Septiembre { get; set; }

        public decimal? Octubre { get; set; }

        public decimal? Noviembre { get; set; }

        public decimal? Diciembre { get; set; }

        public decimal? Acumulado { get; set; }

        public decimal? Orden { get; set; }

        public int? Familia { get; set; }
    }
}
