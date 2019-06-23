namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Salida_Pedido_TMP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Usuario { get; set; }

        [StringLength(80)]
        public string Folio_Factura { get; set; }

        [StringLength(80)]
        public string Sucursal { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Fecha_Emision { get; set; }

        [StringLength(300)]
        public string Nombre_Cliente { get; set; }

        public int? Auxiliar { get; set; }

        [StringLength(80)]
        public string Factura_Estatus { get; set; }

        public int? Numero_Cliente { get; set; }

        public int? Numero_Factura { get; set; }

        public int? Clas_Almacen { get; set; }

        [StringLength(80)]
        public string Des_Almacen { get; set; }

        [StringLength(80)]
        public string Tipo_Documento { get; set; }

        [StringLength(100)]
        public string Serie { get; set; }
    }
}
