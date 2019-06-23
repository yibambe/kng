namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lista_Precios_Detalle
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Lista { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Taller_Concepto { get; set; }

        public int? Clas_Producto { get; set; }

        public int? Clas_Tipo_Concepto { get; set; }

        public int? Clas_Concepto { get; set; }

        public byte? Orden { get; set; }

        public decimal? Porcentaje_Importe { get; set; }

        public int Familia { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }

        public virtual Clasificacion Clasificacion1 { get; set; }

        public virtual Clasificacion Clasificacion2 { get; set; }

        public virtual Descuento_Concepto Descuento_Concepto { get; set; }

        public virtual Lista_Precios Lista_Precios { get; set; }
    }
}
