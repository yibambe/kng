namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Flujo_Efectivo_Encabezado
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        public DateTime? Fecha_de { get; set; }

        public DateTime? Fecha_hasta { get; set; }

        public byte? Unidad_Tiempo { get; set; }

        public byte? Cantidad_Tiempo { get; set; }

        public int? Moneda { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public byte? Autorizada { get; set; }
    }
}
