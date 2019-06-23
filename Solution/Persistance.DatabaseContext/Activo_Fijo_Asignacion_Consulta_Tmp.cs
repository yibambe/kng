namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Activo_Fijo_Asignacion_Consulta_Tmp
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Usuario { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(150)]
        public string Asignado { get; set; }

        [StringLength(100)]
        public string Departamento { get; set; }

        [StringLength(50)]
        public string Cve_Concepto { get; set; }

        [StringLength(100)]
        public string Concepto { get; set; }

        [StringLength(100)]
        public string Tipo_Activo { get; set; }

        [StringLength(1024)]
        public string Descripcion { get; set; }

        public int? MOI { get; set; }

        public decimal? Porcentaje_depreciasion { get; set; }

        public int? Clas_Concepto { get; set; }

        public int? Clas_Tipo_Activo { get; set; }
    }
}
