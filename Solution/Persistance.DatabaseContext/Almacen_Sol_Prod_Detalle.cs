namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Almacen_Sol_Prod_Detalle
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Solicitud { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Familia_Producto { get; set; }

        public decimal Cantidad { get; set; }

        public decimal? Cantidad_Recibida { get; set; }

        public int? Numero_UMedida { get; set; }

        public int? Familia_UMedida { get; set; }

        public int chk_Empaque { get; set; }

        public int? Secuencia { get; set; }

        public virtual Almacen_Sol_Produccion Almacen_Sol_Produccion { get; set; }

        public virtual Receta_Detalle Receta_Detalle { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }
    }
}
