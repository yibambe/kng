namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sol_Prod_Detalle_Transformada
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

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Secuencia { get; set; }

        public int Clasificacion_TProducto { get; set; }

        public int Clasificacion_Producto { get; set; }

        public int Clasificacion_TConcepto { get; set; }

        public int Clasificacion_Concepto { get; set; }

        public int Familia_Concepto { get; set; }

        public decimal Cantidad { get; set; }

        public decimal? Cantidad_Recibida { get; set; }

        public int? Numero_UMedida { get; set; }

        public int? Familia_UMedida { get; set; }

        public virtual Almacen_Sol_Produccion Almacen_Sol_Produccion { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }

        public virtual Clasificacion Clasificacion3 { get; set; }

        public virtual Clasificacion Clasificacion4 { get; set; }
    }
}
