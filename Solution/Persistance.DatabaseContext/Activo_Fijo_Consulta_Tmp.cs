namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Activo_Fijo_Consulta_Tmp
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
        public string Inventario { get; set; }

        [StringLength(50)]
        public string Cve_Concepto { get; set; }

        [StringLength(100)]
        public string Concepto { get; set; }

        [StringLength(50)]
        public string Tipo_Activo { get; set; }

        public DateTime? Fecha_Adquisicion { get; set; }

        [StringLength(15)]
        public string Factura { get; set; }

        public int? Proveedor { get; set; }

        [StringLength(1024)]
        public string Descripcion { get; set; }

        public decimal? Moi { get; set; }

        public decimal? Porcentaje_depreciasion { get; set; }

        public int? Clas_Concepto { get; set; }

        public int? Clas_Tipo_Activo { get; set; }

        public int? Moneda { get; set; }

        public decimal? Tipo_Cambio { get; set; }
    }
}
