namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Almacen")]
    public partial class Almacen
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int? Numero_Almacen { get; set; }

        public int? Numero_Estatus { get; set; }

        public int? Numero_Domicilio { get; set; }

        public decimal? Stock_Minimo { get; set; }

        public decimal? Stock_Maximo { get; set; }

        public int? Cont_Clas_Almacen { get; set; }

        public short? Familia { get; set; }

        public int? Familia_Domicilio { get; set; }

        public byte? Obligatorio_Salida_Manual { get; set; }
    }
}
