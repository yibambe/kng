namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Nomina_Fac_Rechazados
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Numero { get; set; }

        [StringLength(4)]
        public string compania { get; set; }

        [StringLength(60)]
        public string nombre_compania { get; set; }

        [StringLength(10)]
        public string agrupacion { get; set; }

        [StringLength(40)]
        public string nombre_agrupacion { get; set; }

        [StringLength(10)]
        public string dato { get; set; }

        [StringLength(40)]
        public string nombre_dato { get; set; }

        [StringLength(10)]
        public string trabajador { get; set; }

        [StringLength(100)]
        public string nombre_trabajador { get; set; }

        [StringLength(250)]
        public string descripcion { get; set; }

        public decimal? sueldo_diario { get; set; }

        public decimal? sueldo_integrado { get; set; }

        public decimal? sueldo_neto { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha_ini { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha_fin { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fecha { get; set; }

        public bool? Facturado { get; set; }

        public int? Numero_Factura_Nomina { get; set; }

        public int? Numero_factura_Comisiones { get; set; }

        public int? Numero_Factura_Nomina_Comision { get; set; }

        [StringLength(10)]
        public string referencia { get; set; }

        [StringLength(10)]
        public string Plaza { get; set; }

        [StringLength(50)]
        public string Comentario { get; set; }
    }
}
