namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Almacen_Listado
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Usuario { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_Almacen { get; set; }

        [StringLength(100)]
        public string Almacen { get; set; }

        [StringLength(50)]
        public string Clave { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        public string Parte { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string Ubicacion { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal Costo { get; set; }

        public decimal? Existencia { get; set; }

        [StringLength(50)]
        public string UM { get; set; }
    }
}
