namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Activo_Fijo_Baja
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Alta_Activo { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Alta_Activo_Detalle { get; set; }

        public int Clas_Concepto { get; set; }

        public int Clas_Activo { get; set; }

        public DateTime Fecha { get; set; }

        public int Clas_Causa { get; set; }

        public int? Cliente { get; set; }

        public decimal? Importe_Venta { get; set; }

        [StringLength(250)]
        public string Observaciones { get; set; }

        public int? Persona_Beneficiario { get; set; }

        public int Familia { get; set; }

        public decimal? Depreciacion_Acumulada { get; set; }

        public decimal? Valor_Libros { get; set; }
    }
}
