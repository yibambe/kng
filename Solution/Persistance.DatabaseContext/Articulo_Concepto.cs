namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Articulo_Concepto
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Compra { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tipo_Concepto { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Concepto { get; set; }

        public int? Unidad_Medida { get; set; }

        public decimal? Cantidad_UM { get; set; }

        [StringLength(8000)]
        public string Caracteristicas { get; set; }

        [StringLength(80)]
        public string Parte { get; set; }

        public decimal? SMinimo { get; set; }

        public decimal? SMaximo { get; set; }

        public int? Familia { get; set; }

        [StringLength(80)]
        public string Nombre_Corto { get; set; }

        [StringLength(200)]
        public string Codigo { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }
    }
}
