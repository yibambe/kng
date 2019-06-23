namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Entrada_Almacen_Detalle_Serie
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Entrada { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Almacen { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Partida { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [StringLength(50)]
        public string Relacion_Salida { get; set; }

        [StringLength(50)]
        public string Serie { get; set; }

        public int? Clas_Inventario { get; set; }

        public decimal? Costo { get; set; }

        public decimal? Tipo_Cambio { get; set; }

        public int? Clas_Moneda { get; set; }

        [StringLength(50)]
        public string Codigo_Barra { get; set; }

        [StringLength(50)]
        public string Numero_Apartado { get; set; }

        public int Familia_Tipo_Inventario { get; set; }

        public int Familia_Moneda { get; set; }

        public int? Numero_Salida { get; set; }

        public int? Partida_Salida { get; set; }

        public int? Secuencia { get; set; }
    }
}
