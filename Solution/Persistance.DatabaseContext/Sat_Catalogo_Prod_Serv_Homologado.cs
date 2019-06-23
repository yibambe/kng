namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sat_Catalogo_Prod_Serv_Homologado
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string c_ClaveProdServ { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clas_TProducto { get; set; }

        public int? Clas_Producto { get; set; }

        public int? Clas_TConcepto { get; set; }

        public int? Clas_Concepto { get; set; }

        public int? Familia { get; set; }
    }
}
