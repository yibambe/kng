namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Compras_Configuracion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public byte? Par_Precio { get; set; }

        public byte? Par_Producto { get; set; }

        public byte? Num_Decimales { get; set; }

        public decimal? Costo_Minimo { get; set; }

        public decimal? Costo_Maximo { get; set; }
    }
}
