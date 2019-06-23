namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Salida_Almacen_Detalle_No
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Salida { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Almacen { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Partida { get; set; }

        [StringLength(10)]
        public string Numero_RC { get; set; }

        public int? Numero_Articulo_RC { get; set; }

        public decimal? Cantidad_Recibida { get; set; }

        public int? Unidad_Medida { get; set; }

        public decimal? Cantidad_Entregada { get; set; }

        [StringLength(50)]
        public string Lote { get; set; }

        public int Clas_Ubicacion { get; set; }

        public int Clas_Tipo_Inventario { get; set; }

        public decimal? Cantidad_Facturada { get; set; }

        [StringLength(150)]
        public string Nombre_Concepto { get; set; }

        public int Familia_UM { get; set; }

        public int Familia_Inventario { get; set; }

        public decimal Costo { get; set; }

        public int Clas_Moneda { get; set; }

        public decimal Tipo_Cambio { get; set; }

        public int Familia_Moneda { get; set; }
    }
}
