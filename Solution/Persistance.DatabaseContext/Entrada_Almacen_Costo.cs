namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Entrada_Almacen_Costo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Almacen { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Entrada { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Partida { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal Cantidad { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal Costo { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal Tipo_Cambio { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Moneda { get; set; }

        public decimal? Cantidad_Entregada { get; set; }

        public int? Numero_Salida { get; set; }

        public int? Numero_S { get; set; }

        public int? Secuencia { get; set; }

        public decimal? Cantidad_Base { get; set; }

        public decimal? Cantidad_Entregada_Base { get; set; }

        public int? Secuencia_Costeo { get; set; }

        public decimal? Cantidad_Recibida_Base { get; set; }

        public int? Secuencia_S { get; set; }
    }
}
