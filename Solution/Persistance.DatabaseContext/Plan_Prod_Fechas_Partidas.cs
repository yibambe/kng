namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Plan_Prod_Fechas_Partidas
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Fecha { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Partida { get; set; }

        public int Tipo { get; set; }

        public int Numero_Cotiza { get; set; }

        public int Numero { get; set; }

        public decimal Cantidad { get; set; }

        public int? Numero_Orden { get; set; }

        public int? chk_Orden { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Entrega_Partida { get; set; }

        public virtual Orden_Produccion Orden_Produccion { get; set; }

        public virtual Plan_Prod_Fechas Plan_Prod_Fechas { get; set; }
    }
}
