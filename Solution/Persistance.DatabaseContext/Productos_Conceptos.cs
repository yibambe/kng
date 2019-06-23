namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Productos_Conceptos
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clasificacion_Producto { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clasificacion_Concepto { get; set; }

        public decimal Precio { get; set; }

        public int? Unidad_Costo { get; set; }

        public bool Monto { get; set; }

        public int? Unidad_Rango { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal Hasta { get; set; }

        public int? Periodo_Pago { get; set; }

        public decimal? Costo { get; set; }

        public decimal? Porcentaje { get; set; }

        public int Familia_Prod_Concepto_UCosto { get; set; }

        public int Familia_Periodo_Pago { get; set; }

        [StringLength(40)]
        public string Nombre_Corto { get; set; }

        [StringLength(100)]
        public string Codigo { get; set; }

        [StringLength(4000)]
        public string Caracteristicas { get; set; }

        [StringLength(80)]
        public string Parte { get; set; }

        public int? Estatus { get; set; }

        public decimal? Peso { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
