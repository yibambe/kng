namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Almacen_Sol_Prod_Empaques
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Solicitud { get; set; }

        public int Numero_Almacen { get; set; }

        public int Familia_Almacen { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Numero_Empaque { get; set; }

        public int Familia_Empaque { get; set; }

        public decimal Cantidad { get; set; }

        public decimal? Cantidad_Recibida { get; set; }

        public int? Numero_UMedida { get; set; }

        public int? Familia_UMedida { get; set; }

        public int? Secuencia { get; set; }

        [StringLength(50)]
        public string Lote { get; set; }

        public int? Numero_Entrada { get; set; }

        public int? Numero_Partida { get; set; }

        public int? Clas_Producto_Empaque { get; set; }

        public virtual Almacen_Sol_Produccion Almacen_Sol_Produccion { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }
    }
}
