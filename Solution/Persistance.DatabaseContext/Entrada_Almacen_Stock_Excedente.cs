namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Entrada_Almacen_Stock_Excedente
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public DateTime Fecha { get; set; }

        public int Concepto { get; set; }

        public int? Num_Concepto { get; set; }

        public int Clas_Almacen { get; set; }

        public int Clas_Producto { get; set; }

        public int Clas_Concepto { get; set; }

        public decimal Cantidad_Execente { get; set; }

        public int Familia { get; set; }

        public int Visto { get; set; }

        public int Tipo { get; set; }
    }
}
