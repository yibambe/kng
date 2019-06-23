namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Activo_Fijo_Alta_Detalle
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int Numero_Activo_Fijo_Alta { get; set; }

        public int Numero_Detalle { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public decimal Monto { get; set; }

        public byte Estatus { get; set; }

        public int Clas_Tipo_Activo_Fijo { get; set; }

        public int? Clas_Caracteristica { get; set; }

        [StringLength(100)]
        public string Descripcion_Caracteristica { get; set; }

        [StringLength(5)]
        public string Clave_Inventario { get; set; }

        public int? Numero_Inventario { get; set; }

        [StringLength(250)]
        public string Observaciones { get; set; }

        public decimal Monto_X_Tipo_Cambio { get; set; }

        public int Numero_Activo_Total { get; set; }

        public int Familia_Tipo_Activo { get; set; }
    }
}
