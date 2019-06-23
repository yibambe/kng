namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pedido_Articulo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int? Numero_Pedido { get; set; }

        public int? Numero_Empresa { get; set; }

        public int? Numero_Articulo { get; set; }

        public double? Cantidad { get; set; }

        public double? Cantidad_Pendiente { get; set; }

        public int? Numero_Kit { get; set; }

        public double? Precio { get; set; }
    }
}
