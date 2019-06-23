namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Inventario_Movimientos
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int? Numero_E_S { get; set; }

        public int? Concepto_E_S { get; set; }

        public int? Numero_Usuario { get; set; }

        public int? Clas_Articulo { get; set; }

        public int? Clas_Almacen { get; set; }

        public int? Clas_Ubicacion { get; set; }

        public DateTime? Fecha { get; set; }

        public double? Cantidad { get; set; }

        public double? Costo { get; set; }

        [StringLength(50)]
        public string Serie { get; set; }

        [StringLength(50)]
        public string Lote { get; set; }

        [StringLength(1)]
        public string Signo { get; set; }
    }
}
