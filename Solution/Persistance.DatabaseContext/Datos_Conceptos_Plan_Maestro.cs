namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Datos_Conceptos_Plan_Maestro
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Anio { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Periodo { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Secuencia_Dato { get; set; }

        public int Clas_TProducto { get; set; }

        public int Clas_Producto { get; set; }

        public int Clas_TConcepto { get; set; }

        public int Clas_Concepto { get; set; }

        public int Familia { get; set; }

        public decimal? Inventario_Inicial { get; set; }

        public decimal? Inventario_Final { get; set; }

        public decimal? Inventario_Deseado { get; set; }

        public decimal? Back_Order { get; set; }

        public decimal? OP_Proceso { get; set; }

        public decimal? Pronostico { get; set; }

        public decimal? Cantidad { get; set; }

        public decimal? Produccion_Entrega { get; set; }

        public int Clas_UM { get; set; }

        public int Familia_UM { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Programada { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }

        public virtual Clasificacion Clasificacion3 { get; set; }

        public virtual Clasificacion Clasificacion4 { get; set; }
    }
}
