namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tipo_Cambio
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Clas_Moneda_Origen { get; set; }

        public int Clas_Moneda_Destino { get; set; }

        public decimal Compra { get; set; }

        public decimal Venta { get; set; }

        public DateTime Fecha { get; set; }

        public int Usuario { get; set; }

        public short Familia_Clas_Moneda { get; set; }
    }
}
