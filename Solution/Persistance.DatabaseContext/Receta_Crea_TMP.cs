namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Receta_Crea_TMP
    {
        public int? Numero_Empresa { get; set; }

        public int? Numero_Usuario { get; set; }

        [Key]
        public int Numero { get; set; }

        [StringLength(100)]
        public string Concepto { get; set; }

        [StringLength(100)]
        public string UM { get; set; }

        public byte? Tipo { get; set; }

        [StringLength(100)]
        public string Materia_Prima { get; set; }

        [StringLength(100)]
        public string Materia_Prima_UM { get; set; }

        public decimal? Cantidad { get; set; }

        [StringLength(500)]
        public string Problema { get; set; }

        public int? Clas_Concepto { get; set; }

        public int? Clas_Concepto_UM { get; set; }

        public int? Clas_MP { get; set; }

        public int? Clas_MP_UM { get; set; }
    }
}
