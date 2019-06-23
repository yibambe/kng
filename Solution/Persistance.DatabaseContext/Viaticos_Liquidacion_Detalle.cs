namespace Persistance.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Viaticos_Liquidacion_Detalle
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Adeudo { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero_Liquidacion { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        public int Clas_Moneda { get; set; }

        public int Concepto_Viaticos { get; set; }

        public int Clas_Iva { get; set; }

        public DateTime Fecha_Comprobacion { get; set; }

        public decimal Importe { get; set; }

        public decimal Tipo_Cambio { get; set; }

        public decimal Monto_TC { get; set; }

        [StringLength(80)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        public string Comprobante { get; set; }

        public int? Clas_SubCuenta { get; set; }

        public int? Clas_Cuenta { get; set; }

        public int Usuario { get; set; }

        public int Familia_Moneda { get; set; }

        public int Familia_Contabilidad { get; set; }

        public int Familia_Iva { get; set; }

        public int? Facturado { get; set; }

        public int? Tipo_Docto { get; set; }

        [StringLength(50)]
        public string Num_Docto { get; set; }
    }
}
