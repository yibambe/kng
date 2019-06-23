namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ubicacion_Articulo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        public int Numero_Almacen { get; set; }

        public int Numero_Articulo { get; set; }

        public int Clas_Producto { get; set; }

        public int Clas_TConcepto { get; set; }

        public int Clas_Concepto { get; set; }

        public int? Numero_Ubicacion { get; set; }

        public decimal Stock_Minimo { get; set; }

        public decimal Stock_Maximo { get; set; }

        public int? Cont_Clas_Articulo { get; set; }

        public byte Tipo { get; set; }

        public int? Estatus { get; set; }

        public short Familia { get; set; }

        public int Familia_Almacen { get; set; }

        public decimal? Stock_Aviso { get; set; }
    }
}
