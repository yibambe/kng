namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Factura_Interface_Relacion_Empresa
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Registro { get; set; }

        public int Empresa_Facturar { get; set; }

        public int Empresa_Facturacion { get; set; }

        public int Clas_TConcepto { get; set; }

        public int Clas_Concepto { get; set; }

        public decimal Porcentaje { get; set; }

        public int Familia { get; set; }
    }
}
