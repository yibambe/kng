namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Almacen_Transferencia_Detalle_No
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Transferencia { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Partida { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre_Articulo { get; set; }

        public decimal Cantidad { get; set; }

        [StringLength(50)]
        public string Lote { get; set; }

        public int Unidad_Medida { get; set; }

        [StringLength(100)]
        public string Numero_Entrada { get; set; }

        public int? Numero_Entrada_Partida { get; set; }

        public int Familia_Unidad_Medida { get; set; }

        public int? Clas_Tipo_Inventario { get; set; }

        public int Familia_Inventario { get; set; }

        public decimal? Cantidad_Entregada { get; set; }
    }
}