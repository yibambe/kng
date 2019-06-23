namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Catalogo_Inventarios_ag
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int usuario { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime fecha { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int almacen { get; set; }

        [StringLength(10)]
        public string cve_almacen { get; set; }

        [StringLength(100)]
        public string des_almacen { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int clas_producto { get; set; }

        [StringLength(150)]
        public string desc_clas_producto { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int clas_concepto { get; set; }

        [StringLength(150)]
        public string desc_clas_concepto { get; set; }

        [StringLength(4)]
        public string clave_concepto { get; set; }

        [StringLength(150)]
        public string nombre_corto { get; set; }

        public decimal? Inicial { get; set; }

        public decimal? Entrada { get; set; }

        public decimal? Salida { get; set; }
    }
}
