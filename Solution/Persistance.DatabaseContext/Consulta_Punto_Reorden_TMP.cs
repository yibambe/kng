namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Consulta_Punto_Reorden_TMP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Usuario { get; set; }

        public int? Clas_Almacen { get; set; }

        [StringLength(80)]
        public string Des_Almacen { get; set; }

        public int? Clas_Producto { get; set; }

        [StringLength(80)]
        public string Des_Producto { get; set; }

        public int? Clas_Concepto { get; set; }

        [StringLength(80)]
        public string Cve_Concepto { get; set; }

        [StringLength(80)]
        public string Des_Concepto { get; set; }

        public decimal? Disponible { get; set; }

        public decimal? Promedio_Dia { get; set; }

        public decimal? Disponible_Dia { get; set; }

        public decimal? Pendiente_Llegar { get; set; }

        public decimal? Stock_Maximo { get; set; }

        public decimal? Disponible_Maximo { get; set; }

        public decimal? Stock_Reposicion { get; set; }

        public decimal? Disponible_Reposicion { get; set; }

        public decimal? Stock_Minimo { get; set; }

        public decimal? Disponible_Minimo { get; set; }

        public decimal? Compra_Sugerida { get; set; }

        public int? Clas_UM { get; set; }

        [StringLength(80)]
        public string Des_UM { get; set; }

        public byte? Auxiliar { get; set; }

        public int? Familia { get; set; }
    }
}
