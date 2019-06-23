namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Activo_Fijo_Consulta_Depreciacion_Tmp
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Usuario { get; set; }

        [StringLength(50)]
        public string Cve_Concepto { get; set; }

        [StringLength(100)]
        public string Concepto { get; set; }

        [StringLength(100)]
        public string Tipo_Activo { get; set; }

        public DateTime? Fecha_Adquisicion { get; set; }

        [StringLength(20)]
        public string Factura { get; set; }

        [StringLength(1024)]
        public string Descripcion { get; set; }

        public decimal? Moi { get; set; }

        public decimal? Porc_Depre_Anual { get; set; }

        public decimal? Monto_Depre_Anual { get; set; }

        public decimal? Monto_Depre_mensual { get; set; }

        public int? Num_Meses_A_Depreciar { get; set; }

        public int? Num_Meses_Depreciados { get; set; }

        public int? Num_Meses_Depreciar_Ejercicio { get; set; }

        public int? Num_Meses_Por_Depre { get; set; }

        public decimal? Depre_Acumulada { get; set; }

        public decimal? Depre_Ejercicio { get; set; }

        public decimal? Depre_Total { get; set; }

        public int? Clas_Concepto { get; set; }

        public int? Clas_Tipo_Activo { get; set; }
    }
}
